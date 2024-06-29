namespace AbstractFactory;

public class IronDoorFactory: IDoorFactory
{
    public IDoor MakeDoor()
    {
        return new IronDoor();
    }

    public IDoorFittingExpert MakeDoorFittingExpert()
    {
        return new Welder();
    }
}