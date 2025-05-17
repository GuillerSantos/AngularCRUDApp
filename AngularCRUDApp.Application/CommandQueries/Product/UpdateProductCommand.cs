using AngularCRUDApp.Application.DTOs;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class UpdateProductCommand : IRequest<Guid>
    {
        #region Properties

        public UpdateProductDto Product { get; set; }

        #endregion Properties
    }
}