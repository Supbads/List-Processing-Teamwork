namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;
    using Helpers;

    public class PrependCommand : Command
    {
        public PrependCommand(string action, IList<string> parameters) 
            : base(action, parameters)
        {
        }

        public override void Execute()
        {
            this.Data.Insert(0, this.Parameters[0]);
            HelperCommands.Print(this.Data);
        }
    }
}