using AngularCRUDApp.Application.CommandQueries.Product;
using AngularCRUDApp.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AngularCRUDApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        #region Public Methods

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
        {
            var productId = await mediator.Send(command);
            return Ok($"Product ID: {productId}");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductDto updatedproduct)
        {
            if (updatedproduct.Id != updatedproduct.Id)
            {
                return BadRequest("Product ID Mismatch");
            }

            var command = new UpdateProductCommand
            {
                Product = updatedproduct
            };

            try
            {
                var result = await mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteProductsCommand { Id = id };

            var result = await mediator.Send(command);
            return Ok(result);
        }

        #endregion Public Methods
    }
}