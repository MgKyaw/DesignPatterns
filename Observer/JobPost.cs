namespace Observer;

class JobPost
{
    public string Name { get; private set; }

    public JobPost(string name)
    {
        Name = name;
    }
}