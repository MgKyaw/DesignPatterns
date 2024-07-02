namespace Command;

// Invoker
class RemoteControl
{
    public void Submit(ICommand command)
    {
        command.Execute();
    }

    public void Cancel(ICommand command)
    {
        command.Undo();
    }
}