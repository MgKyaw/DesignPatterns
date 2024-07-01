namespace Facade;

class ComputerFacade
{
    private Computer mComputer;

    public ComputerFacade(Computer computer)
    {
        mComputer = computer ?? throw new ArgumentNullException(nameof(computer), "computer can not be null!");
    }

    public void TurnOn()
    {
        mComputer.GetElectricShock();
        mComputer.MakeSound();
        mComputer.ShowLoadingScreen();
        mComputer.Bam();
    }

    public void TurnOff()
    {
        mComputer.CloseEverything();
        mComputer.PullCurrent();
        mComputer.Sooth();
    }
}