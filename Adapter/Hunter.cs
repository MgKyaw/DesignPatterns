namespace Adapter;

public class Hunter
{
    private ILion mLion;

    public void Hunt(ILion lion)
    {
        this.mLion = lion;
        mLion.Roar();
    }
}