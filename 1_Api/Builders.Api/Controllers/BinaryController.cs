using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Domain.EntranceTestContext.Queries;
using Builders.Shared.Commands;
using Builders.Shared.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Builders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryController : BaseController
    {

        [HttpPost]
        [Route("")]
        public async Task<ICommandResult> Create([FromServices] IMediator mediator, [FromBody] CriaBinaryCommand command)
        {
            command.Validate();
            if (command.Valid)
                return await mediator.Send(command);
            return new CommandResult(false, "Erros", command.Notifications);
        }

        
        [HttpGet]
        [Route("")]
        public async Task<IQueryResult> Get([FromServices] IMediator mediator, [FromBody] BinaryReadQuery query)
        {
            query.Validate();
            if (query.Valid)
                return await mediator.Send(query);
            return new QueryResult(false, "Erros", query.Notifications);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IQueryResult> GetAll([FromServices] IMediator mediator, [FromBody] BinaryReadAllQuery query)
        {
            query.Validate();
            if (query.Valid)
                return await mediator.Send(query);
            return new QueryResult(false, "Erros", query.Notifications);
        }

    }
}
