namespace AbstractFactory;

public class WoodenDoor: IDoor
{
    public void GetDescription()
    {
        System.Console.WriteLine("I am a wooden door!");
    }
}