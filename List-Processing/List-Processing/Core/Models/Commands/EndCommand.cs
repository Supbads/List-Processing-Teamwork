using System.Collections.Generic;

namespace List_Processing.Core.Models.Commands
{
    public class EndCommand : Command
    {
        public EndCommand(IList<string> parameters)
            : base(parameters)
        {
        }

        public override void Execute(Data data)
        {
            data.EndReceived = true;
        }
    }
}
