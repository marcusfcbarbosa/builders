using Builders.Api.services;
using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Commands.Output;
using Builders.Shared.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Builders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("")]
        [AllowAnonymous]
        public async Task<ICommandResult> Post([FromBody] AuthenticationCommand command)
        {
            try
            {
                command.Validate();
                if (!command.Valid)
                    return new CommandResult(false, "Erros", command.Notifications);

                if (command.UserName == "Admin" && command.PassWord == "123456")
                {
                    var token = TokenService.GenerateToken(command.UserName);
                    return new CommandResult(true, "", new
                    {
                        token = "Bearer " + token
                    });
                }
                else
                {
                    return new CommandResult(false, "404", StatusCodes.Status404NotFound);
                }
            }
            catch (Exception ex)
            {
                return new CommandResult(false, ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
}
