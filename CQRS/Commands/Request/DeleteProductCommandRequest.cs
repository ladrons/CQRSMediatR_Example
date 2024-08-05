using CQRSMediatR_Example.CQRS.Commands.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}