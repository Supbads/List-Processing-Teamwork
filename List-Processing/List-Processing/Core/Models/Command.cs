using System.Collections.Generic;

namespace List_Processing.Core.Models
{
    public class Command
    {
        public Command()
        {
        }

        public Command(string action, List<string> parameters)
        {
            Action = action;
            Parameters = parameters;
        }

        public string Action { get; set; }

        public List<string> Parameters { get; set; } = new List<string>();
    }
}