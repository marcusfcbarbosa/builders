using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Domain.EntranceTestContext.Queries;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Shared.Queries;
using MediatR;
using System;
using System.Linq;
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

        public async Task<IQueryResult> Handle(BinaryReadQuery request, CancellationToken cancellationToken)
        {
            var document = await _binaryRepository.GetById(request.id);
            var node = document.three.Where(x => x.Value == request.Valor).FirstOrDefault().Node;
            return await Task.FromResult(new QueryResult(true, "", node));
        }
        public async Task<IQueryResult> Handle(BinaryReadAllQuery request, CancellationToken cancellationToken)
        {
            var querie = await _binaryRepository.GetAll();
            return await Task.FromResult(new QueryResult(true, "", querie));
        }
    }
}