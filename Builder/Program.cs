namespace Builder;

class Program
{
    public static void Main(string[] args)
    {
        var burger = new BurgerBuilder(4).AddCheese()
                .AddPepperoni()
                .AddLettuce()
                .AddTomato()
                .Build();

        System.Console.WriteLine(burger.GetDescription());
    }
}