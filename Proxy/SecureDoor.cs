namespace Proxy;

class SecureDoor : IDoor
{
    private IDoor mDoor;

    public SecureDoor(IDoor door)
    {
        this.mDoor = door ?? throw new ArgumentNullException(nameof(door), "door can not be null.");
    }

    public void AuthenticateAndOpen(string password)
    {
        if(Authenticate(password))
        {
            mDoor.Open();
        }
        else {
            Console.WriteLine("Big no, it ain't possible.");
        }
    }

    private bool Authenticate(string password)
    {
        return password == "$ecr@t";
    }

    public void Open()
    {
        Console.WriteLine("Please use AuthenticateAndOpen method with a password.");
    }

    public void Close()
    {
        mDoor.Close();
    }
}