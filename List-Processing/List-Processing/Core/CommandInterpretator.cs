using System;
using System.Collections.Generic;
using System.Linq;
using List_Processing.Core.Models;

namespace List_Processing.Core
{
    public class CommandInterpretator
    {
        public CommandInterpretator()
        {
        }

        public void Seed(List<string> collection, string input)
        {
            collection.AddRange(input.Split().ToList());
        }


        public Command ParseCommand(string commandInput)
        {
            var command = new Command();

            var commandArguments = commandInput.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var action = commandArguments[0];
            var parameters = commandArguments.Skip(1).ToList();

            command.Action = action;
            command.Parameters = parameters;

            return command;
        }
    }
}