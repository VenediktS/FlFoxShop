using FlFoxShop.Common.DBModels;
using FlFoxShop.Common.DTOs.ProductDTOs;
using FlFoxShop.Domain.ProductRequests;

using MediatR;

using Microsoft.AspNetCore.Mvc;


namespace FlFoxShop.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestContoroller : ControllerBase
    {
        private readonly IMediator _mediator;
        public TestContoroller(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            return Ok($"Its works");
        }

        [HttpPost("test-add")]
        public async Task<ActionResult<Product>> AddProduct(AddTextileDTO model, CancellationToken token) 
        {
            var entity = await _mediator.Send(new AddTextileRequest(model), token);
            return Ok(entity);
        }
    }
}
