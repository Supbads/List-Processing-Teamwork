﻿namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;

    public class ReverseCommand : Command
    {
        public ReverseCommand(IList<string> parameters) 
            : base(parameters)
        {
        }

        public override void Execute(Data data)
            => data.DataParams.Reverse();
    }
}
