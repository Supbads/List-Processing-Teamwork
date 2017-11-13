namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;

    public class AppendCommand : Command
    {
        public AppendCommand(string action, IList<string> parameters) 
            : base(action, parameters)
        {
        }

        public override void Execute(Data data)
        {
            data.DataParams.Add(this.Parameters[0]);
        }
    }
}