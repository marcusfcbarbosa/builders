using Builders.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;
using MediatR;

namespace Builders.Domain.EntranceTestContext.Commands.Input
{
    public class AuthenticationCommand : Notifiable, ICommand, IRequest<ICommandResult>
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public void Validate()
        {
            AddNotifications(new ValidationContract()
                 .Requires()
                 .IsNotNull(UserName, "UserName", "UserName é obrigatório")
             );
            AddNotifications(new ValidationContract()
                .Requires()
                .IsNotNull(PassWord, "PassWord", "PassWord é obrigatório")
            );
        }
    }
}
