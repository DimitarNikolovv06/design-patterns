namespace DesignPatterns.Command
{
    interface ICommand
    {
        void Execute();

        string GetCommandName();
    }
}
