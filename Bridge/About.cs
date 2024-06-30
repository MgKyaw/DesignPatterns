namespace Bridge;

public class About: IWebPage
{
    protected ITheme mTheme;
    public About(ITheme theme)
    {
        this.mTheme = theme;
    }

    public void GetContent()
    {
        System.Console.WriteLine($"About page in {mTheme.GetColor()} color!");
    }
}