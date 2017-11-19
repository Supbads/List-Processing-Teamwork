using System.Linq;

namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;
    using System;
    using List_Processing.Helpers;


    public class CountCommand : Command
    {
        public CountCommand(IList<string> parameters)
            : base(parameters)
        {
        }

        public override void Execute(Data data)
        {
            var word = this.Parameters[0];

            var count = data.DataParams.Count(s => s == word);
            Console.WriteLine(count);

        }

    }
}
