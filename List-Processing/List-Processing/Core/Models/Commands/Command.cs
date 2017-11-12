namespace List_Processing.Core.Models.Commands
{
    using System.Collections.Generic;
    using Contracts;

    public abstract class Command : ICommand
    {
        private readonly Data data;

        protected Command(string action, IList<string> parameters)
        {
            this.Action = action;
            this.Parameters = parameters;
            this.Data = data.DataParams;
        }

        public string Action { get; set; }

        public IList<string> Parameters { get; set; }

        public IList<string> Data { get; private set; } = new List<string>();

        public abstract void Execute();
    }
}