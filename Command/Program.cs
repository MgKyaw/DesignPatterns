namespace Command;

class Program 
{
    static void Main(string[] args)
    {
        var bulb = new Bulb();

        var turnOn = new TurnOn(bulb);
        var turnOff = new TurnOff(bulb);

        var remoteControl = new RemoteControl();
        remoteControl.Submit(turnOn);
        remoteControl.Submit(turnOff);

        remoteControl.Submit(turnOn);
        remoteControl.Cancel(turnOn);
    }
}