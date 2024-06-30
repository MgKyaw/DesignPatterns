namespace Prototype;

public class Sheep
{
    public string Name { get; set; }
    public string Category { get; set; }

    public Sheep(string name, string category)
    {
        this.Name = name;
        this.Category = category;
    }

    public Sheep Clone()
    {
        return MemberwiseClone() as Sheep;
    }
}