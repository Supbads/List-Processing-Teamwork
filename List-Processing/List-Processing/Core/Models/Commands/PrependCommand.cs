namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;

    public class PrependCommand : Command
    {
        public PrependCommand(string action, IList<string> parameters) 
            : base(action, parameters)
        {
        }

        public override void Execute(Data data)
        {
            data.DataParams.Insert(0, this.Parameters[0]);
        }
    }
}