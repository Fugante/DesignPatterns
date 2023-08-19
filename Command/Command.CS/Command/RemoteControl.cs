using CommandPattern;

namespace CommandPattern.Controls;


public class SimpleRemoteControl
{
    public Command Slot;

    public SimpleRemoteControl(){}

    public void SetCommand(Command command)
    {
        this.Slot = command;
    }

    public void ButtonWasPressed()
    {
        this.Slot.Execute();
    }
}