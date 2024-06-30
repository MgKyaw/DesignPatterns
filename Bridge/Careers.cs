namespace Bridge;

public class Careers: IWebPage
{
    protected ITheme mTheme;

    public Careers(ITheme theme)
    {
        this.mTheme = theme;
    }

    public void GetContent()
    {
        System.Console.WriteLine($"Careers page in {mTheme.GetColor()} color!");
    }
}