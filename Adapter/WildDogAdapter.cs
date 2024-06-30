namespace Adapter;

public class WildDogAdapter: ILion
{
    public WildDog mWildDog;
    
    public WildDogAdapter(WildDog wildDog)
    {
        mWildDog = wildDog;
    }

    public void Roar()
    {
        mWildDog.Bark();
    }
}