namespace Decorator;

class MilkCoffee : ICoffee
{
    private ICoffee mCoffee;

    public MilkCoffee(ICoffee coffee)
    {
        mCoffee = coffee ?? throw new ArgumentNullException(nameof(coffee), "coffee must not be null!");
    }

    public int GetCost()
    {
        return mCoffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return $"{mCoffee.GetDescription()}, Milk";
    }
}