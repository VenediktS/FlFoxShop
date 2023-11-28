using FlFoxShop.Common.DBModels;
using FlFoxShop.Common.DBModels.TextileModels;
using FlFoxShop.Common.DTOs.ProductDTOs;
using FlFoxShop.DataBase;

using MediatR;

namespace FlFoxShop.Domain.ProductRequests
{
    /// <summary>
    /// Добавление новой позиции
    /// </summary>
    public class AddTextileRequest : IRequest<Textile>
    {
        private readonly AddTextileDTO _model;
        public AddTextileRequest(AddTextileDTO model) 
        {
            _model = model;
        }

        public class AddTextileRequestHandler : IRequestHandler<AddTextileRequest, Textile>
        {
            private readonly ShopDbContext _dbContext;
            public AddTextileRequestHandler(ShopDbContext dbContext) 
            { 
                _dbContext = dbContext;
            }

            public async Task<Textile> Handle(AddTextileRequest request, CancellationToken cancellationToken)
            {
                var product = new Textile()
                {
                    Title = request._model.Title,
                    Description = request._model.Description
                };

                await _dbContext.AddAsync(product);
                await _dbContext.SaveChangesAsync();

                return product;
            }
        }
    }
}
