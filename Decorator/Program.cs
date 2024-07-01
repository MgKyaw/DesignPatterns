namespace Decorator;

class Program 
{
    static void Main(string[] args)
    {
        var simpleCoffee = new SimpleCoffee();
        System.Console.WriteLine($"{simpleCoffee.GetCost():c}");
        System.Console.WriteLine(simpleCoffee.GetDescription());

        var milkCoffee = new MilkCoffee(simpleCoffee);
        System.Console.WriteLine($"{milkCoffee.GetCost():c}");
        System.Console.WriteLine(milkCoffee.GetDescription());

        var whipCoffee = new WhipCoffee(milkCoffee);
        System.Console.WriteLine($"{whipCoffee.GetCost():c}");
        System.Console.WriteLine(whipCoffee.GetDescription());

        var vanillaCoffee = new VanillaCoffee(whipCoffee);
        System.Console.WriteLine($"{vanillaCoffee.GetCost():c}");
        System.Console.WriteLine(vanillaCoffee.GetDescription());
    }
}