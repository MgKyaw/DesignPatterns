namespace Facade;

class Program 
{
    static void Main(string[] args)
    {
        var computer = new Computer();
        var computerFacade = new ComputerFacade(computer);

        computerFacade.TurnOn();

        computerFacade.TurnOff();
    }
}