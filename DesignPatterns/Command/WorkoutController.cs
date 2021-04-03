using System;


namespace DesignPatterns.Command
{
    class WorkoutController
    {

        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
            Console.WriteLine($"The fitness instructor set the command {command.GetCommandName()}");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine($"Now executing {command.GetCommandName()} command");
            this.command.Execute();
        }
    }
}
