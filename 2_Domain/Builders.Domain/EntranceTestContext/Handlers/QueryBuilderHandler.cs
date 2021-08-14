using Builders.Domain.EntranceTestContext.Queries;
using Builders.Shared.Queries;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Builders.Domain.EntranceTestContext.Handlers
{
    public class QueryBuilderHandler
        : IRequestHandler<BinaryReadQuery, IQueryResult>,
        IRequestHandler<BinaryReadAllQuery, IQueryResult>

    {
        public Task<IQueryResult> Handle(BinaryReadQuery request, CancellationToken cancellationToken)
        {
            //aqui retorno um no da lista
            throw new NotImplementedException();
        }
        public Task<IQueryResult> Handle(BinaryReadAllQuery request, CancellationToken cancellationToken)
        {
            //aqui retorno todas
            throw new NotImplementedException();
        }
    }
}