using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class DeleteProductsCommand : IRequest<Guid>
    {
        #region Properties

        public Guid Id { get; set; }

        #endregion Properties
    }
}