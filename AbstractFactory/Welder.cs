namespace AbstractFactory;

public class Welder: IDoorFittingExpert
{
    public void GetDescription()
    {
        System.Console.WriteLine("I can fit only the iron door!");
    }
}