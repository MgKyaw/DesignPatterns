namespace AbstractFactory;

public class IronDoor: IDoor
{
    public void GetDescription()
    {
        System.Console.WriteLine("I am an iron door!");
    }
}