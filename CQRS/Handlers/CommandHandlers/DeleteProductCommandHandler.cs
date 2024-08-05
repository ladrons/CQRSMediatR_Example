using CQRSMediatR_Example.Context;
using CQRSMediatR_Example.CQRS.Commands.Request;
using CQRSMediatR_Example.CQRS.Commands.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellation)
        {
            var deleteProduct = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);

            ApplicationDbContext.ProductList.Remove(deleteProduct);

            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}