using CQRSMediatR_Example.CQRS.Queries.Response;
using MediatR;

namespace CQRSMediatR_Example.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {

    }
}