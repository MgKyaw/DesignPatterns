namespace Flyweight;

class Program
{
    static void Main(string[] args)
    {
        var teaMaker = new TeaMaker();
        var teaShop = new TeaShop(teaMaker);

        teaShop.TakeOrder(1, "less sugar");
        teaShop.TakeOrder(2, "more milk");
        teaShop.TakeOrder(3, "without sugar");

        teaShop.Serve();
        // Serving tea to table# 1
        // Serving tea to table# 2
        // Serving tea to table# 3
    }
}