namespace List_Processing.Core.Contracts
{
    using System.Collections.Generic;
    using List_Processing.Core.Models;

    public interface ICommand
    {
        IList<string> Parameters { get; }

        void Execute(Data data);
    }
}