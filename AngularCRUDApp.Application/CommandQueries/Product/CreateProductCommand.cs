using AngularCRUDApp.Application.DTOs;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class CreateProductCommand : IRequest<Guid>
    {
        #region Properties

        public ProductDto Product { get; set; }

        #endregion Properties
    }
}