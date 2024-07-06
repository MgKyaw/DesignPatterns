namespace State;

class Program {
    static void Main(string[] args)
    {
        var textEditor = new TextEditor();

        textEditor.Type("First line");

        textEditor.Set(new UpperCase());
        textEditor.Type("Second Line");

        textEditor.Set(new LowerCase());
        textEditor.Type("Third Line");
    }
}