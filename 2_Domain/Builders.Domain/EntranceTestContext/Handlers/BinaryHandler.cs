using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Shared.Commands;
using System;

namespace Builders.Domain.EntranceTestContext.Handlers
{
    public class BinaryHandler : 
        ICommandHandler<CriaBinaryCommand>
    {
        private readonly IBinaryRepository _binaryRepository;
        public BinaryHandler(IBinaryRepository binaryRepository)
        {
            _binaryRepository = binaryRepository;
        }

        public ICommandResult Handle(CriaBinaryCommand command)
        {
            //implemento os paranaue aqui

            throw new NotImplementedException();
        }
    }
}
