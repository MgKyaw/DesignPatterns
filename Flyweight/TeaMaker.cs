namespace Flyweight;

class TeaMaker()
{
    private Dictionary<string, KarakTea> mAvailableTeas = new Dictionary<string, KarakTea>();

    public KarakTea Make(string type)
    {
        if(!mAvailableTeas.ContainsKey(type))
        {
            mAvailableTeas.Add(type, new KarakTea());
        }

        return mAvailableTeas[type];
    }
}