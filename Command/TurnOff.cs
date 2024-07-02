namespace Command;

class TurnOff : ICommand
{
    private Bulb mBulb;

    public TurnOff(Bulb bulb)
    {
        mBulb = bulb ?? throw new ArgumentNullException(nameof(bulb), "bulb cannot be null");
    }

    public void Execute()
    {
        mBulb.TurnOff();
    }

    public void Undo()
    {
        mBulb.TurnOn();
    }

    public void Redo()
    {
        Execute();
    }
}