namespace Mediator;

class User
{
    private string mName { get; set;}
    private IChatRoomMediator mChatRoom { get; set; }

    public User(string name, IChatRoomMediator chatRoom)
    {
        mName = name;
        mChatRoom = chatRoom;
    }

    public string GetName()
    {
        return mName;
    }

    public void Send(string message)
    {
        mChatRoom.ShowMessage(this, message);
    }
}