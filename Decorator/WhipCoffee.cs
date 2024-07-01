namespace Decorator;

class WhipCoffee : ICoffee
{
    private ICoffee mCoffee;

    public WhipCoffee(ICoffee coffee)
    {
        mCoffee = coffee ?? throw new ArgumentNullException(nameof(coffee), "coffee must not be null!");
    }

    public int GetCost()
    {
        return mCoffee.GetCost() + 2;
    }

    public string GetDescription()
    {
        return $"{mCoffee.GetDescription()}, Whip";
    }
}