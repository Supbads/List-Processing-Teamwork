using List_Processing.Core.Models;

namespace List_Processing.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using List_Processing.Core.Models.Commands;
    using List_Processing.Helpers;

    public class CommandInterpreter
    {
        private Logger logger;

        public CommandInterpreter(Logger logger)
        {
            this.logger = logger;
        }

        public void Seed(List<string> collection, string input)
        {
            collection.AddRange(input.Split().ToList());
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
            switch (action)
            {
                case "append":
                    ValidateCommandLength(length, Messages.AppendCommandLength);

                    command = new AppendCommand(action, parameters);
                    break;                   
                case "prepend":
                    ValidateCommandLength(length, Messages.PrependCommandLength);

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
                    logger.Write(Messages.FinishedMessage);

                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException(Messages.InvalidCommand);
            }

            return command;
        }

        private void ValidateCommandLength(int length, int reqLength)
        {
            bool isCommandLengthValid = IsCommandLengthValid(length,
                reqLength);

            if (!isCommandLengthValid)
            {
                throw new ArgumentException(Messages.InvalidParameters);
            }
        }

        private bool IsCommandLengthValid(int length, int reqLength)
        {
            return Utils.CheckCommandLength(
                length,
                reqLength);
        }
    }
}