using List_Processing.Core.Models;

namespace List_Processing.Core
{
    using System;
    using System.Linq;
    using List_Processing.Core.Models.Commands;
    using List_Processing.Helpers;
    using List_Processing.Core.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private Logger logger;

        public CommandInterpreter(Logger logger)
        {
            this.logger = logger;
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

                    command = new AppendCommand(parameters);
                    break;                   
                case "prepend":
                    ValidateCommandLength(length, Messages.PrependCommandLength);

                    command = new PrependCommand(parameters);
                    break;
                case "reverse":
                    ValidateCommandLength(length, Messages.ReverseCommandLength);

                    command = new ReverseCommand(parameters);
                    break;
                case "insert":
                    ValidateCommandLength(length, Messages.InsertCommandLength);

                    command = new InsertCommand(parameters);
                    break;
                case "delete":
                    break;
                case "roll":
                    ValidateCommandLength(length, Messages.RollCommandLength);

                    command = new RollCommand(parameters);
                    break;
                case "sort":
                    ValidateCommandLength(length, Messages.SortCommandLength);

                    command = new SortCommand(parameters);
                    break;
                case "count":
                    break;
                case "end":
                    logger.Write(Messages.FinishedMessage);

                    command = new EndCommand(parameters);
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