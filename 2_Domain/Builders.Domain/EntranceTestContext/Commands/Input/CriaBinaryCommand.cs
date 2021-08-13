using Builders.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;
using MediatR;
using System.Collections.Generic;

namespace Builders.Domain.EntranceTestContext.Commands.Input
{
    public class CriaBinaryCommand : Notifiable, ICommand, IRequest<ICommandResult>
    {
        public IEnumerable<Request> inputs { get; set; }

        public void Validate()
        {
            foreach (var item in inputs)
            {
                AddNotifications(new ValidationContract()
                 .Requires()
                 .IsNotNull(item.Value, "Value", "Value é obrigatório")
                 .IsLowerThan(0, item.Value, "Value", "Value deve ser maior que zero (0)")
             );

            }
        }
    }

    public class Request
    {

        public int Value { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
    }
}
