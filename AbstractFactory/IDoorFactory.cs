namespace AbstractFactory;

public interface IDoorFactory
{
    IDoor MakeDoor();
    IDoorFittingExpert MakeDoorFittingExpert();
}