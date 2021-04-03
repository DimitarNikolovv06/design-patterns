using DesignPatterns.Observer;
using System;

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
                Console.WriteLine($" {Name} is already in up state, provide a new command.");
            }
            else
            {
                stateUp = true;
                Console.WriteLine($" {Name} is now in up state");
            }

        }

        public void SwitchDown()
        {
            if (!stateUp)
            {
                Console.WriteLine($" {Name} is already in down state, provide a new command.");
            }
            else
            {
                stateUp = false;
                Console.WriteLine($" {Name} is now in down state");
            }
        }
    }
}
