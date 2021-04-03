using DesignPatterns.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    interface IObservable
    {
        void Subscribe(IObserver observer);

        void UnSubscribe(IObserver observer);

        void NotifyObservers(string commandName);

        void SwitchDown();

        void SwitchUp();

    }
}
