using CommandPattern.Executors;
using CommandPattern.Controls;
using CommandPattern;


// public class RemoteControlTest
// {
//     public static void Main()
//     {
//         SimpleRemoteControl remote = new();
//         Light light = new();
//         GarageDoor garageDoor = new();
//         LightOnCommand lightOn = new(light);
//         GarageDoorOpenCommand garageOpen = new(garageDoor);

//         remote.SetCommand(lightOn);
//         remote.ButtonWasPressed();
//         remote.SetCommand(garageOpen);
//         remote.ButtonWasPressed();
//     }
// }

public class RemoteLoader
{
    public static void Main()
    {
        RemoteControl remoteControl = new();

        Light livingRoomLight = new("Living Room");
        Light kitchenLight = new("Kitchen");
        CeilingFan ceilingFan = new("Living Room");
        GarageDoor garageDoor = new("Garage");
        Stereo stereo = new("Living Room");

        // OBJECT ORIENTED WAY
        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);
        LightOnCommand kitchenLightOn = new(kitchenLight);
        LightOffCommand kitchenLightOff = new(kitchenLight);

        CeilingFanMediumCommand ceilingFanMedium = new(ceilingFan);
        CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

        GarageDoorUpCommand garageDoorUp = new(garageDoor);
        GarageDoorDownCommand garageDoorDown = new(garageDoor);

        StereoOnWithCDCommand stereoOnWithCD = new(stereo);
        StereoOffCommand stereoOff = new(stereo);

        Command[] partyOn = {livingRoomLightOn, kitchenLightOn, garageDoorUp};
        Command[] partyOff = {livingRoomLightOff, kitchenLightOff, garageDoorDown};
        MacroCommand partyOnMacro = new(partyOn);
        MacroCommand partyOffMacro = new(partyOff);

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanMedium, ceilingFanOff);
        remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);
        remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

        remoteControl.SetCommand(5, partyOnMacro, partyOffMacro);

        // // FUNCTIONAL(ISH) APPROACH
        // remoteControl.SetCommand(
        //       0
        //     , () => livingRoomLight.On()
        //     , () => livingRoomLight.Off()
        // );
        // remoteControl.SetCommand(
        //       1
        //     , () => kitchenLight.On()
        //     , () => kitchenLight.Off()
        // );
        // remoteControl.SetCommand(
        //       2
        //     , () => ceilingFan.On()
        //     , () => ceilingFan.Off()
        // );
        // remoteControl.SetCommand(
        //     3
        //     , () => {
        //         stereo.On();
        //         stereo.SetCd();
        //         stereo.SetVolume(11);
        //       }
        //     , () => stereo.Off()
        // );

        Console.WriteLine(remoteControl);
        // remoteControl.OnButtonWasPressed(0);
        // remoteControl.OffButtonWasPressed(0);
        // remoteControl.OnButtonWasPressed(1);
        // remoteControl.OffButtonWasPressed(1);
        // remoteControl.OnButtonWasPressed(4);
        // remoteControl.OffButtonWasPressed(4);
        // remoteControl.UndoButtonWasPressed();

        remoteControl.OnButtonWasPressed(2);
        remoteControl.OffButtonWasPressed(2);
        Console.WriteLine(remoteControl);
        remoteControl.UndoButtonWasPressed();

        remoteControl.OnButtonWasPressed(3);
        Console.WriteLine(remoteControl);
        remoteControl.UndoButtonWasPressed();

        // Console.WriteLine(remoteControl);
        // Console.WriteLine("--- Pushing Macro On---");
        // remoteControl.OnButtonWasPressed(5);
        // Console.WriteLine("--- Pushing Macro Off---");
        // remoteControl.OffButtonWasPressed(5);
    }
}