using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Shared.Commands;
using MediatR;
using System;
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

        public Task<ICommandResult> Handle(CriaBinaryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
