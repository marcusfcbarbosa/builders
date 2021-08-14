using Builders.Shared.Queries;
using FluentValidator;
using MediatR;

namespace Builders.Domain.EntranceTestContext.Queries
{
    public class BinaryReadAllQuery : Notifiable, IQuerie, IRequest<IQueryResult>
    {
        public void Validate()
        {
        }
    }
}
