using AngularCRUDApp.Application.Common.Interfaces;
using AngularCRUDApp.Domain.Entities;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class CreateProductHandler(
        IApplicationDbContext dbContext
        ) : IRequestHandler<CreateProductCommand, Guid>
    {
        #region Public Methods

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Products
            {
                ProductName = request.Product.ProductName,
                ProductDescription = request.Product.ProductDescription,
                ProductPrice = request.Product.ProductPrice,
                ProductStock = request.Product.ProductStock,
                ProductImage = request.Product.ProductImage,
                ProductCategory = request.Product.ProductCategory,
                ProductBrand = request.Product.ProductBrand,
                CreatedAt = DateTime.UtcNow
            };
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync(cancellationToken);

            return product.Id;
        }

        #endregion Public Methods
    }
}