namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        var originalSheep = new Sheep("Jolly", "Mountain Sheep");
        System.Console.WriteLine(originalSheep.Name);
        System.Console.WriteLine(originalSheep.Category);

        var cloned = originalSheep.Clone();
        cloned.Name = "Dolly";
        System.Console.WriteLine(cloned.Name);
        System.Console.WriteLine(cloned.Category);
        System.Console.WriteLine(originalSheep.Name);
    }
}