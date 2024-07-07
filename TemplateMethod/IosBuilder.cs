namespace TemplateMethod;

class IosBuilder : Builder
{
    public override void Test()
    {
        Console.WriteLine("Running ios tests.");
    }

    public override void Lint()
    {
        Console.WriteLine("Lint the ios code.");
    }

    public override void Assemble()
    {
        Console.WriteLine("Assembling the ios build.");
    }

    public override void Deploy()
    {
        Console.WriteLine("Deploying ios build to server.");
    }
}