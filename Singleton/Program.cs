namespace Singleton;

class Program 
{
    static void Main(string[] args)
    {
        President a = President.GetInstance();
        President b = President.GetInstance();

        System.Console.WriteLine(a == b); // True
    }
}