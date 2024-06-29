namespace SimpleFactory;

public class WoodenDoor: IDoor
{
    private int Width { get; set; }
    private int Height { get; set; }

    public WoodenDoor(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int GetWidth()
    {
        return this.Width;
    }

    public int GetHeight()
    {
        return this.Height;
    }
}