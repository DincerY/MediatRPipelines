namespace MediatRPipelines.Application.Features.Product.GetProduct;

public class GetProductResponse
{
    public string Message { get; set; }
    public Domain.Entities.Product Product { get; set; }
    public bool Status { get; set; }
}