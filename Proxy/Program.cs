namespace Proxy;

class Program 
{
    static void Main(string[] args)
    {
        var secureDoor = new SecureDoor(new LabDoor());
        secureDoor.AuthenticateAndOpen("invalid");
        secureDoor.AuthenticateAndOpen("12345");

        secureDoor.AuthenticateAndOpen("$ecr@t");
        secureDoor.Close();
    }
}