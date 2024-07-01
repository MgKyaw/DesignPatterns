namespace Flyweight;

class TeaShop
{
    private Dictionary<int, KarakTea> mOrders = new Dictionary<int, KarakTea>();
    private TeaMaker mTeaMaker;

    public TeaShop(TeaMaker teaMaker)
    {
        mTeaMaker = teaMaker ?? throw new ArgumentNullException(nameof(teaMaker), "teaMaker cannot be null");
    }

    public void TakeOrder(int table, string teaType)
    {
        mOrders[table] = mTeaMaker.Make(teaType);
    }

    public void Serve()
    {
        foreach (var table in mOrders.Keys)
        {
            Console.WriteLine($"Serving tea to table # {table}");
        }
    }
}