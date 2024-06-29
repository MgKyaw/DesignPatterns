namespace SimpleFactory;

public static class DoorFactory
{
    public static IDoor MakeDoor(int width, int height)
    {
        return new WoodenDoor(width, height);
    }
}