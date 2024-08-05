using CQRSMediatR_Example.Context;
using CQRSMediatR_Example.CQRS.Commands.Request;
using CQRSMediatR_Example.CQRS.Commands.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellation)
        {
            var id = Guid.NewGuid();

            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                CreatedDate = DateTime.Now
            });

            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id
            };
        }
    }
}