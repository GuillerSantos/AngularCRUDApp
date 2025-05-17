using AngularCRUDApp.Application.Common.Interfaces;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class UpdateProductHandler(
        IApplicationDbContext dbContext
        ) : IRequestHandler<UpdateProductCommand, Guid>
    {
        #region Public Methods

        public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await dbContext.Products.FindAsync(new object[] { request.Product.Id }, cancellationToken);

            if (product is null)
            {
                throw new Exception($"Product not found.");
            }

            product.ProductName = request.Product.ProductName;
            product.ProductDescription = request.Product.ProductDescription;
            product.ProductPrice = request.Product.ProductPrice;
            product.ProductStock = request.Product.ProductStock;
            product.ProductImage = request.Product.ProductImage;
            product.ProductCategory = request.Product.ProductCategory;
            product.ProductBrand = request.Product.ProductBrand;

            await dbContext.SaveChangesAsync(cancellationToken);

            return product.Id;
        }

        #endregion Public Methods
    }
}