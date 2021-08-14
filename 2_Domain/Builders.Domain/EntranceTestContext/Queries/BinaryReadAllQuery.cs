using Builders.Shared.Queries;
using MediatR;

namespace Builders.Domain.EntranceTestContext.Queries
{
    public class BinaryReadAllQuery : IQuerie, IRequest<IQueryResult>
    {
        public void Validate()
        {
        }
    }
}
