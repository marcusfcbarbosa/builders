using Builders.Domain.EntranceTestContext.Adapters;
using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Shared.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Builders.Domain.EntranceTestContext.Handlers
{
    public class BinaryHandler
        : IRequestHandler<CriaBinaryCommand, ICommandResult>
    {
        private readonly IBinaryRepository _binaryRepository;
        public BinaryHandler(IBinaryRepository binaryRepository)
        {
            _binaryRepository = binaryRepository;
        }      

        public async Task<ICommandResult> Handle(CriaBinaryCommand request, CancellationToken cancellationToken)
        {
            var document = DocumentAdapter.CommandToDocument(request);
            await _binaryRepository.CreateAsync(document);
            return await Task.FromResult(new CommandResult(true, "Árvore de pesquisa binária cadastrada com sucesso!", document));
        }
    }
}
