using Builders.Domain.EntranceTestContext.Adapters;
using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Domain.EntranceTestContext.Documents;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Shared.Commands;
using Builders.Shared.Utils;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Builders.Domain.EntranceTestContext.Handlers
{
    public class BuildersHandler
        : IRequestHandler<CriaBinaryCommand, ICommandResult>,
          IRequestHandler<CriaPalindromeCommand, ICommandResult>
    {
        private readonly IBinaryRepository _binaryRepository;
        private readonly IPalindromeRepository _palindromeRepository;

        public BuildersHandler(IBinaryRepository binaryRepository,
                               IPalindromeRepository palindromeRepository)
        {
            _binaryRepository = binaryRepository;
            _palindromeRepository = palindromeRepository;
        }

        public async Task<ICommandResult> Handle(CriaBinaryCommand request,
            CancellationToken cancellationToken)
        {
            var document = DocumentAdapter.CommandToDocument(request);
            await _binaryRepository.CreateAsync(document);
            return await Task.FromResult(new CommandResult(true, "Árvore de pesquisa binária cadastrada com sucesso!", document));
        }

        public async Task<ICommandResult> Handle(CriaPalindromeCommand request, 
                                                CancellationToken cancellationToken)
        {
            var document = new PalindromeDocument(request.Valor, request.Valor.ToLower() == request.Valor.ToLower().reverseString());
            await _palindromeRepository.CreateAsync(document);
            return await Task.FromResult(new CommandResult(true, "", document));
        }
    }
}
