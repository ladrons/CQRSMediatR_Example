using CQRSMediatR_Example.Context;
using CQRSMediatR_Example.CQRS.Queries.Request;
using CQRSMediatR_Example.CQRS.Queries.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellation)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreatedDate = product.CreatedDate
            };
        }
    }
}