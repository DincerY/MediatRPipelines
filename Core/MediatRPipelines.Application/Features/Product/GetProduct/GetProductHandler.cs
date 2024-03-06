using MediatR;

namespace MediatRPipelines.Application.Features.Product.GetProduct;

public class GetProductHandler : IRequestHandler<GetProductRequest,GetProductResponse>
{
    public async Task<GetProductResponse> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        return new GetProductResponse()
        {
            Message = "Oluşturuldu",
            Product = new()
            {
                Id = 1,
                Name = "Kalem"
            },
            Status = true
        };
    }
}