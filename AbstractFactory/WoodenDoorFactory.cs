namespace AbstractFactory;

public class WoodenDoorFactory: IDoorFactory
{
    public IDoor MakeDoor()
    {
        return new WoodenDoor();
    }

    public IDoorFittingExpert MakeDoorFittingExpert()
    {
        return new Carpenter();
    }
}