namespace Decorator;

class VanillaCoffee : ICoffee
{
    private ICoffee mCoffee;

    public VanillaCoffee(ICoffee coffee)
    {
        mCoffee = coffee ?? throw new ArgumentNullException(nameof(coffee), "coffee must not be null!");
    }

    public int GetCost()
    {
        return mCoffee.GetCost() + 3;
    }

    public string GetDescription()
    {
        return $"{mCoffee.GetDescription()}, Vanilla";
    }
}