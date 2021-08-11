using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Interfaces;
using Builders.Shared.Commands;
using FluentValidator;
using System;

namespace Builders.Domain.EntranceTestContext.Handlers
{
    public class BinaryHandler : Notifiable,
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
