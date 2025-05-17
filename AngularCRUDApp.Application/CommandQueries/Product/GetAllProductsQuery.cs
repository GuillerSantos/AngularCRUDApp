using AngularCRUDApp.Application.DTOs;
using MediatR;

namespace AngularCRUDApp.Application.CommandQueries.Product
{
    public class GetAllProductsQuery : IRequest<List<ProductDto>>
    {
    }
}