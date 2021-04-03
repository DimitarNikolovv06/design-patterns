using DesignPatterns.ObserverAndObservable;
using System;

namespace DesignPatterns.Command
{
    class SwitchUpCommand : ICommand
    {

        private TrainingGuy trainingGuy;
        private string commandName = "Up";

        public SwitchUpCommand()
        {
        }

        public void SetTrainingGuy(TrainingGuy trainingGuy)
        {
            this.trainingGuy = trainingGuy;
        }

        public SwitchUpCommand(TrainingGuy trainingGuy)
        {
            this.trainingGuy = trainingGuy;
        }
        public void Execute()
        {
            if (trainingGuy == null)
            {
                Console.WriteLine("You have not set the training guy");
                return;
            }
            this.trainingGuy.SwitchUp();
            this.trainingGuy.NotifyObservers(commandName);
        }

        public string GetCommandName()
        {
            return commandName;
        }
    }
}
