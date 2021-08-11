using Builders.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace Builders.Domain.EntranceTestContext.Commands.Input
{
    public class CriaBinaryCommand : Notifiable, ICommand
    {
        public int Value { get; private set; }
        public string Left { get; private set; }
        public string Right { get; private set; }

        public void Validate()
        {
            AddNotifications(new ValidationContract()
                 .Requires()
                 .IsNotNull(Value, "Value", "Value é obrigatório")
                 .IsLowerThan(0, Value, "Value", "Value deve ser maior que zero (0)")
             );
        }
    }
}
