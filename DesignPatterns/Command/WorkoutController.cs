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
            if (this.command != null)
            {
                Console.WriteLine($"The fitness instrictor is now executing the {command.GetCommandName()} command");
                this.command.Execute();

            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
