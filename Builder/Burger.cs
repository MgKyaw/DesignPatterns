using System.Text;

namespace Builder;

public class Burger
{
    private int mSize { get; set; }
    private bool mCheese { get; set; }
    private bool mPepperoni { get; set; }
    private bool mLettuce { get; set; }
    private bool mTomato { get; set; }

    public Burger(BurgerBuilder builder)
    {
        this.mSize = builder.Size;
        this.mCheese = builder.Cheese;
        this.mPepperoni = builder.Pepperoni;
        this.mLettuce = builder.Lettuce;
        this.mTomato = builder.Tomato;
    }

    public string GetDescription()
    {
        var sb = new StringBuilder();
        sb.Append($"This is {this.mSize} inch burger.");
        return sb.ToString();
    }
}