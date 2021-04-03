using DesignPatterns.Command;
using DesignPatterns.Observer;
using System;
using System.Collections.Generic;

namespace DesignPatterns.ObserverAndObservable
{
    class TrainingGuy : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void NotifyObservers(string commandName)
        {

            foreach (var observer in observers)
            {
                if (commandName == "Up")
                {
                    observer.SwitchUp();
                }
                if (commandName == "Down")
                {
                    observer.SwitchDown();
                }
            }
        }

        public void Subscribe(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void SwitchDown()
        {
            Console.WriteLine("The training guy is now in down state");
        }

        public void SwitchUp()
        {
            Console.WriteLine("The training guy is now in up state");
        }

        public void UnSubscribe(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
