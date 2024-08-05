using CQRSMediatR_Example.Context;
using CQRSMediatR_Example.CQRS.Queries.Request;
using CQRSMediatR_Example.CQRS.Queries.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellation)
        {
            return ApplicationDbContext.ProductList.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreatedDate = product.CreatedDate
            }).ToList();           
        }
    }
}