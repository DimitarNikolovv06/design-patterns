using DesignPatterns.ObserverAndObservable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class SwitchUpCommand : ICommand
    {

        private TrainingGuy trainingGuy;
        private string commandName = "Up";



        public SwitchUpCommand(TrainingGuy trainingGuy)
        {
            this.trainingGuy = trainingGuy;
        }
        public void Execute()
        {
            this.trainingGuy.SwitchUp();
            this.trainingGuy.NotifyObservers(commandName);
        }

        public string GetCommandName()
        {
            return commandName;
        }
    }
}
