using DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverAndObservable
{
    class Watcher : IObserver
    {

        private bool stateUp = true;
        public string Name { get; set; }

        public Watcher(string name)
        {
            this.Name = name;
        }

        public void SwitchUp()
        {
            if (stateUp)
            {
                Console.WriteLine($" {Name} is already in up state");
            }
            else
            {
                stateUp = false;
                Console.WriteLine($" {Name} is now in up state");
            }

        }

        public void SwitchDown()
        {
            if (!stateUp)
            {
                Console.WriteLine($" {Name} is already in down state");
            }
            else
            {
                Console.WriteLine($" {Name} is now in down state");
            }
        }
    }
}
