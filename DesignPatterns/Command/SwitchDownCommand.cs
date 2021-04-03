using DesignPatterns.ObserverAndObservable;
using System;

namespace DesignPatterns.Command
{
    class SwitchDownCommand : ICommand
    {
        private TrainingGuy trainingGuy;
        private string commandName = "Down";

        public SwitchDownCommand()
        {
        }

        public void SetTrainingGuy(TrainingGuy trainingGuy)
        {
            this.trainingGuy = trainingGuy;
        }

        public SwitchDownCommand(TrainingGuy trainingGuy)
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

            this.trainingGuy.SwitchDown();
            this.trainingGuy.NotifyObservers(commandName);
        }

        public string GetCommandName()
        {
            return commandName;
        }
    }
}
