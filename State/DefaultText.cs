namespace State;

class DefaultText : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words);
    }
}