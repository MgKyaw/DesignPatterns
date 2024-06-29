namespace SimpleFactory;

class Program
{
    public static void Main(string[] args)
    {
        var woodenDoor = DoorFactory.MakeDoor(10, 20);
        System.Console.WriteLine($"Wooden door - Width: {woodenDoor.GetWidth()}");
        System.Console.WriteLine($"Wooden door - Height: {woodenDoor.GetHeight()}");
    }
}
