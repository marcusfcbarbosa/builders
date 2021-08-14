using Builders.Shared.Queries;
using FluentValidator;
using FluentValidator.Validation;
using MediatR;
using System;

namespace Builders.Domain.EntranceTestContext.Queries
{
    public class BinaryReadQuery : Notifiable, IQuerie, IRequest<IQueryResult>
    {
        public Guid id { get; set; }
        public int Valor { get; set; } 
        public void Validate()
        {
            AddNotifications(new ValidationContract()
                .Requires()
                 .IsLowerThan(0, Valor, "Valor", "Valor deve ser maior que zero (0)")
                 .IsFalse(id==Guid.Empty, id.ToString(),"id deve estar preenchido")
                );
        }
    }
}
