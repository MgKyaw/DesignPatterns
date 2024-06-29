namespace FactoryMethod;

public class DeveloperManager: HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}