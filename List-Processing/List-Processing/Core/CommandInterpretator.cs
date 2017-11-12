namespace List_Processing.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using List_Processing.Core.Contracts;
    using List_Processing.Core.Models.Commands;
    using List_Processing.Helpers;
    using Models;

    public class CommandInterpretator
    {
        public CommandInterpretator()
        {
        }

        public void Seed(IEnumerable<string> collection, string input)
        {
            collection.ToList().AddRange(input.Split().ToList());
        }

        public Command ParseCommand(string commandInput)
        {          
            var commandArguments = commandInput.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            // first check if it's a valid command

            var length = commandArguments.Length;

            Command command = null;

            var action = commandArguments[0];
            var parameters = commandArguments.Skip(1).ToList();

            // make it with reflection, if you hate your life
            switch (commandArguments[0])
            {
                case "append":
                    HelperCommands.CheckCommand(
                        action, 
                        Messages.AppendCommandName, 
                        length,
                        Messages.AppendCommandLength);

                    command = new AppendCommand(action, parameters);
                    break;                   
                case "prepend":
                    HelperCommands.CheckCommand(
                        commandInput,
                        Messages.PrependCommandName,
                        length,
                        Messages.PrependCommandLength);

                    command = new PrependCommand(action, parameters);
                    break;
                case "reverse":
                    break;
                case "insert":
                    break;
                case "delete":
                    break;
                case "roll":             
                    break;
                case "sort":                
                    break;
                case "count":
                    break;
                case "end":               
                    break;
            }

            return command;
        }
    }
}