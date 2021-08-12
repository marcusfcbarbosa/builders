using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Shared.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Builders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public async Task<ICommandResult> Create([FromServices] IMediator mediator, [FromBody] CriaBinaryCommand command)
        {
            try
            {
                command.Validate();
                if (command.Valid)
                    return await mediator.Send(command);
                return new CommandResult(false, "Erros", command.Notifications);
            }
            catch (Exception ex)
            {

                return new CommandResult(false, "", StatusCodes.Status500InternalServerError);
            }

        }
    }
}
