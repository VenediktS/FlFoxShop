using Microsoft.AspNetCore.Mvc;

namespace FlFoxShop.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestContoroller : ControllerBase
    {
        public TestContoroller() { }

        [HttpGet("test")]
        public ActionResult<string> Test() 
        {
            return Ok($"Its works");
        }
    }
}
