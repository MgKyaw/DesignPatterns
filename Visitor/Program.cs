namespace Visitor;

class Program 
{
    static void Main(string[] args)
    {
        var monkey = new Monkey();
        var lion = new Lion();
        var dolphin = new Dolphin();

        var speak = new Speak();
        var jump = new Jump();

        monkey.Accept(speak);
        lion.Accept(speak);
        dolphin.Accept(speak);

        monkey.Accept(jump);
        lion.Accept(jump);
        dolphin.Accept(jump);

    }
}
