namespace Decorator;

class SimpleCoffee : ICoffee
{
    public int GetCost()
    {
        return 5;
    }

    public string GetDescription()
    {
        return "Simple Coffee";
    }
}