using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Domain.EntranceTestContext.Queries;
using Builders.Domain.EntranceTestContext.Repositories;
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
        private readonly IBinaryRepository _binaryRepository;
        public QueryBuilderHandler(IBinaryRepository binaryRepository)
        {
            _binaryRepository = binaryRepository;
        }

        public Task<IQueryResult> Handle(BinaryReadQuery request, CancellationToken cancellationToken)
        {
            //aqui retorno um no da lista
            throw new NotImplementedException();
        }
        public async Task<IQueryResult> Handle(BinaryReadAllQuery request, CancellationToken cancellationToken)
        {
            var querie = await _binaryRepository.GetAll();
            return await Task.FromResult(new QueryResult(true, "", querie));
        }
    }
}