namespace TemplateMethod;

class Program 
{
    static void Main(string[] args)
    {
        var androidBuilder = new AndroidBuilder();
        androidBuilder.Build();

        var iosBuilder = new IosBuilder();
        iosBuilder.Build();
    }
}