﻿using Builders.Shared.Commands;

namespace Builders.Domain.EntranceTestContext.Commands.Output
{
    public class CommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public CommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
        
    }
}
