namespace Singleton;

public class President
{
    static President instance;

    private President()
    {

    }

    public static President GetInstance()
    {
        if (instance == null)
        {
            instance = new President();
        }
        return instance;
    }
}