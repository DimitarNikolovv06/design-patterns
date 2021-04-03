using DesignPatterns.ObserverAndObservable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class SwitchDownCommand : ICommand
    {
        private TrainingGuy trainingGuy;
        private string commandName = "Down";

        public SwitchDownCommand(TrainingGuy trainingGuy)
        {
            this.trainingGuy = trainingGuy;
        }
        public void Execute()
        {
            this.trainingGuy.SwitchDown();
            this.trainingGuy.NotifyObservers(commandName);
        }

        public string GetCommandName()
        {
            return commandName;
        }
    }
}
