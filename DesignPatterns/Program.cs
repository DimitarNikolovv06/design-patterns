using DesignPatterns.Command;
using DesignPatterns.ObserverAndObservable;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Watcher watcher1 = new Watcher("Watcher1");
            Watcher watcher2 = new Watcher("Watcher2");
            Watcher watcher3 = new Watcher("Watcher3");
            TrainingGuy trainingGuy = new TrainingGuy();
            trainingGuy.Subscribe(watcher1);
            trainingGuy.Subscribe(watcher2);
            trainingGuy.Subscribe(watcher3);
            WorkoutController workoutController = new WorkoutController();
            SwitchUpCommand switchUpCommand = new SwitchUpCommand(trainingGuy);
            SwitchDownCommand switchDownCommand = new SwitchDownCommand(trainingGuy);

            workoutController.SetCommand(switchUpCommand);
            workoutController.ExecuteCommand();

            workoutController.SetCommand(switchDownCommand);
            workoutController.ExecuteCommand();

            workoutController.SetCommand(switchUpCommand);
            workoutController.ExecuteCommand();
        }
    }
}
