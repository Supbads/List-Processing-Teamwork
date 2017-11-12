namespace List_Processing.Core.Contracts
{
    public interface IEngine
    {
        CommandInterpretator Interpretator { get; }

        CommandExecutor Executor { get; }

        void Run();
    }
}