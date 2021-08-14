using Builders.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;
using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace Builders.Domain.EntranceTestContext.Commands.Input
{
    public class CriaBinaryCommand : Notifiable, ICommand, IRequest<ICommandResult>
    {

        public CriaBinaryCommand() { }
        public CriaBinaryCommand(IEnumerable<Request> inputs)
        {
            this.inputs = inputs;
        }
        public IEnumerable<Request> inputs { get; set; }

        public void Validate()
        {
            for (int i = 0; i < inputs.Count(); i++)
            {
                AddNotifications(new ValidationContract()
                .Requires()
                .IsNotNull(inputs.ElementAt(i).Value, "Value", "Value é obrigatório")
                .IsLowerThan(0, inputs.ElementAt(i).Value, "Value", "Value deve ser maior que zero (0)")
                .IsNotNull(inputs.ElementAt(i).node, "Node", "Node é obrigatório")
                .IsLowerThan(0, inputs.ElementAt(i).node, "Node", "Node deve ser maior que zero (0)")
                );

                if (inputs.ElementAtOrDefault(i + 1) != null)
                {
                    AddNotifications(new ValidationContract()
                    .Requires()
                    .IsLowerThan(inputs.ElementAt(i).Value, inputs.ElementAt(i + 1).Value,"Value", "Arvore Binaria Invalida")
                    .IsLowerThan(inputs.ElementAt(i).node, inputs.ElementAt(i + 1).node, "Node", "Arvore Binaria Invalida")
                    );
                }
            }
        }
    }

    public class Request
    {
        public int node { get; set; }
        public int Value { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
    }
}