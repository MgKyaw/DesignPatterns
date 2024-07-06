namespace State;

class UpperCase : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words.ToUpper());
    }
}