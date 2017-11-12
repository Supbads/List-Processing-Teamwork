namespace List_Processing.Core.Contracts
{
    using System.Collections.Generic;

    public interface ICommand
    {
        string Action { get; }

        IList<string> Parameters { get; }

        IList<string> Data { get; }

        void Execute();
    }
}