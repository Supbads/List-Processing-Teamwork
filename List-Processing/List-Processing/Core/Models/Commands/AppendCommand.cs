namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;
    using Helpers;

    public class AppendCommand : Command
    {
        public AppendCommand(string action, IList<string> parameters) 
            : base(action, parameters)
        {
        }

        public override void Execute()
        {
            this.Data.Add(this.Parameters[0]);
            HelperCommands.Print(this.Data);
        }
    }
}