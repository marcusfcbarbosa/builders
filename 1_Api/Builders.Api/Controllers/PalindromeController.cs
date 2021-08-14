using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Shared.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Builders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromeController : BaseController
    {
        [HttpPost]
        [Route("")]
        public async Task<ICommandResult> Create([FromServices] IMediator mediator, 
                                                 [FromBody] CriaPalindromeCommand command)
        {
            command.Validate();
            if (command.Valid)
                return await mediator.Send(command);
            return new CommandResult(false, "Erros", command.Notifications);
        }
    }
}
