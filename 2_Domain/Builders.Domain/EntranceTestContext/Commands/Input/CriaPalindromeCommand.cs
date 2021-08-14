using Builders.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;
using MediatR;

namespace Builders.Domain.EntranceTestContext.Commands.Input
{
    public class CriaPalindromeCommand : Notifiable, ICommand, IRequest<ICommandResult>
    {
        
        public string Valor { get;  set; }
        public void Validate()
        {
            AddNotifications(new ValidationContract()
                   .Requires()
                   .IsNotNullOrEmpty(Valor, "Valor", "Valor é obrigatorio")
                   );
        }
    }
}
