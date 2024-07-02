namespace Proxy;

class LabDoor : IDoor
{
    public void Open()
    {
        Console.WriteLine("Opening lab door!");
    }

    public void Close()
    {
        Console.WriteLine("Closing lab door!");
    }
}