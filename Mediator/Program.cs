namespace Mediator;

class Program 
{
    static void Main(string[] args)
    {
        var chatRoom = new ChatRoom();

        var john = new User("john", chatRoom);
        var jane = new User("jane", chatRoom);

        john.Send("Hi there!");
        jane.Send("Hey!");
    }
}