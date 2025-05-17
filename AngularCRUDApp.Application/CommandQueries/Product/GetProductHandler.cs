using AngularCRUDApp.Application.Common.Interfaces;
using AngularCRUDApp.Application.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class GetProductHandler(
        IApplicationDbContext dbContext
        ) : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        #region Public Methods

        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await dbContext.Products
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductPrice = p.ProductPrice,
                    ProductStock = p.ProductStock,
                    ProductImage = p.ProductImage,
                    ProductCategory = p.ProductCategory,
                    ProductBrand = p.ProductBrand,
                })
                .ToListAsync(cancellationToken);
        }

        #endregion Public Methods
    }
}