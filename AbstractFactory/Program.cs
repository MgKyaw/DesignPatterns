namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        var woodenDoorFactory = new WoodenDoorFactory();
        var woodenDoor = woodenDoorFactory.MakeDoor();
        var woodenDoorFittingExpert = woodenDoorFactory.MakeDoorFittingExpert();

        woodenDoor.GetDescription();
        woodenDoorFittingExpert.GetDescription();

        var ironDoorFactory = new IronDoorFactory();
        var ironDoor = ironDoorFactory.MakeDoor();
        var ironDoorFittingExpert = ironDoorFactory.MakeDoorFittingExpert();

        ironDoor.GetDescription();
        ironDoorFittingExpert.GetDescription();
    }
}