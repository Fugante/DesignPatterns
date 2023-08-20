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

// OBJECT ORIENTED WAY
public class RemoteControl
{
    public Command[] OnCommands { get; }
    public Command[] OffCommands { get; }
    public Command UndoCommand { get; set; } = new NullCommand();

    public RemoteControl()
    {
        this.OnCommands = new Command[7];
        this.OffCommands = new Command[7];
        for (int i = 0; i < 7; i++)
        {
            this.OnCommands[i] = new NullCommand();
            this.OffCommands[i] = new NullCommand();
        }
    }

    public void SetCommand(int slot, Command onCommand, Command offCommand)
    {
        this.OnCommands[slot] = onCommand;
        this.OffCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot)
    {
        this.OnCommands[slot].Execute();
        this.UndoCommand = this.OnCommands[slot];
    }

    public void OffButtonWasPressed(int slot)
    {
        this.OffCommands[slot].Execute();
        this.UndoCommand = this.OffCommands[slot];
    }

    public void UndoButtonWasPressed()
    {
        this.UndoCommand.Undo();
    }

    public override string ToString()
    {
        string buffer = "\n------ Remote Control -------\n";
        for (int i = 0; i < this.OnCommands.Length; i++)
            buffer += $"[slot {i}] {this.OnCommands[i].GetType().Name} "
                    + $"{this.OffCommands[i].GetType().Name} \n";
        buffer += $"[undo] {this.UndoCommand.GetType().Name} \n";
        return buffer;
    }
}


// // FUNCTIONAL(ISH) APPROACH
// public class RemoteControl
// {
//     public Action[] OnCommands { get; }
//     public Action[] OffCommands { get; }

//     public RemoteControl()
//     {
//         this.OnCommands = new Action[7];
//         this.OffCommands = new Action[7];
//         for (int i = 0; i < 7; i++)
//         {
//             this.OnCommands[i] = () => {};
//             this.OffCommands[i] = () => {};
//         }
//     }

//     public void SetCommand(int slot, Action onCommand, Action offCommand)
//     {
//         this.OnCommands[slot] = onCommand;
//         this.OffCommands[slot] = offCommand;
//     }

//     public void OnButtonWasPressed(int slot)
//     {
//         this.OnCommands[slot]();
//     }

//     public void OffButtonWasPressed(int slot)
//     {
//         this.OffCommands[slot]();
//     }

//     public override string ToString()
//     {
//         string buffer = "\n------ Remote Control -------\n";
//         for (int i = 0; i < this.OnCommands.Length; i++)
//             buffer += $"[slot {i}] {this.OnCommands[i].GetType().Name} "
//                     + $"{this.OffCommands[i].GetType().Name} \n";
//         return buffer;
//     }
// }