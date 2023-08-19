using CommandPattern.Executors;
using CommandPattern.Controls;
using CommandPattern;


public class RemoteControlTest
{
    public static void Main()
    {
        SimpleRemoteControl remote = new();
        Light light = new();
        GarageDoor garageDoor = new();
        LightOnCommand lightOn = new(light);
        GarageDoorOpenCommand garageOpen = new(garageDoor);

        remote.SetCommand(lightOn);
        remote.ButtonWasPressed();
        remote.SetCommand(garageOpen);
        remote.ButtonWasPressed();
    }
}