namespace AbstractFactory;

public class Carpenter: IDoorFittingExpert
{
    public void GetDescription()
    {
        System.Console.WriteLine("I can fit only the wooden door!");
    }
}