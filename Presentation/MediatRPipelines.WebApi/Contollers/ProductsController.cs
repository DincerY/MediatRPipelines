using MediatR;
using MediatRPipelines.Application.Features.Product.GetProduct;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPipelines.WebApi.Contollers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetProduct()
    {
        GetProductResponse response = await _mediator.Send(new GetProductRequest());
        return Ok(response);
    }
}