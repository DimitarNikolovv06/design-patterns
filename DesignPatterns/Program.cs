using DesignPatterns.Command;
using DesignPatterns.FactoryMethod;
using DesignPatterns.ObserverAndObservable;

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
            WorkoutController fitnessInstructor = new WorkoutController();

            SwitchDownCommand switchDownCommand = (SwitchDownCommand)CommandFactory.Create(CommandFactory.commandList.SwitchDown, trainingGuy);
            SwitchUpCommand switchUpCommand = (SwitchUpCommand)CommandFactory.Create(CommandFactory.commandList.SwitchUp);
            switchUpCommand.SetTrainingGuy(trainingGuy);

            fitnessInstructor.SetCommand(switchUpCommand);
            fitnessInstructor.ExecuteCommand();

            fitnessInstructor.SetCommand(switchDownCommand);
            fitnessInstructor.ExecuteCommand();

            fitnessInstructor.SetCommand(switchUpCommand);
            fitnessInstructor.ExecuteCommand();
        }
    }
}
