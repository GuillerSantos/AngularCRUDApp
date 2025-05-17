using AngularCRUDApp.Application.Common.Interfaces;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class DeleteProductHandler(
        IApplicationDbContext dbContext
        ) : IRequestHandler<DeleteProductsCommand, Guid>
    {
        #region Public Methods

        public async Task<Guid> Handle(DeleteProductsCommand request, CancellationToken cancellationToken)
        {
            var product = await dbContext.Products.FindAsync(new object[] { request.Id }, cancellationToken);

            if (product is null)
            {
                throw new Exception("Product Not Found");
            }

            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync(cancellationToken);

            return request.Id;
        }

        #endregion Public Methods
    }
}