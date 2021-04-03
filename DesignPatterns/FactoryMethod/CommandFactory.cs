using DesignPatterns.Command;
using DesignPatterns.ObserverAndObservable;
using System;
using System.ComponentModel;

namespace DesignPatterns.FactoryMethod
{
    class CommandFactory
    {
        public enum commandList
        {
            [Description("SwitchUp")]
            SwitchUp = 1,
            [Description("SwitchDown")]
            SwitchDown = 2
        }
        public static ICommand Create(commandList commandName)
        {
            if (commandName == commandList.SwitchUp)
            {
                return new SwitchUpCommand();
            }
            else if (commandName == commandList.SwitchDown)
            {
                return new SwitchDownCommand();
            }
            else
            {
                Console.WriteLine("Invalid command");
                return null;
            }


        }

        public static ICommand Create(commandList commandName, TrainingGuy trainingGuy)
        {
            if (commandName == commandList.SwitchUp)
            {
                return new SwitchUpCommand(trainingGuy);
            }
            else if (commandName == commandList.SwitchDown)
            {
                return new SwitchDownCommand(trainingGuy);
            }
            else
            {
                Console.WriteLine("Invalid command");
                return null;
            }
        }
    }
}
