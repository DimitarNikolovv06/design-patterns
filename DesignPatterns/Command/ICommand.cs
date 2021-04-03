using DesignPatterns.ObserverAndObservable;

namespace DesignPatterns.Command
{
    interface ICommand
    {
        void Execute();

        void SetTrainingGuy(TrainingGuy trainingGuy);
        string GetCommandName();
    }
}
