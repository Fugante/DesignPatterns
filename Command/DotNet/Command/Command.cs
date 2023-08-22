using CommandPattern.Executors;
namespace CommandPattern;


public interface Command
{
    void Execute();
    void Undo();
}

public class NullCommand : Command
{
    public NullCommand(){}
    public void Execute(){}
    public void Undo(){}
}

public class LightOnCommand : Command
{
    public Light Light_;

    public LightOnCommand(Light light)
    {
        this.Light_ = light;
    }

    public void Execute()
    {
        this.Light_.On();
    }

    public void Undo()
    {
        this.Light_.Off();
    }
}

public class LightOffCommand : Command
{
    public Light Light_;

    public LightOffCommand(Light light)
    {
        this.Light_ = light;
    }

    public void Execute()
    {
        this.Light_.Off();
    }

    public void Undo()
    {
        this.Light_.On();
    }
}

public class GarageDoorUpCommand : Command
{
    public GarageDoor Door;

    public GarageDoorUpCommand(GarageDoor door)
    {
        this.Door = door;
    }

    public void Execute()
    {
        this.Door.Up();
    }

    public void Undo()
    {
        this.Door.Down();
    }
}

public class GarageDoorDownCommand : Command
{
    public GarageDoor Door;

    public GarageDoorDownCommand(GarageDoor door)
    {
        this.Door = door;
    }

    public void Execute()
    {
        this.Door.Down();
    }

    public void Undo()
    {
        this.Door.Up();
    }
}

public class StereoOnWithCDCommand : Command
{
    public Stereo Stereo_;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        this.Stereo_ = stereo;
    }

    public void Execute()
    {
        this.Stereo_.On();
        this.Stereo_.SetCd();
        this.Stereo_.SetVolume(11);
    }

    public void Undo()
    {
        this.Stereo_.Off();
    }
}

public class StereoOffCommand : Command
{
    public Stereo Stereo_;

    public StereoOffCommand(Stereo stereo)
    {
        this.Stereo_ = stereo;
    }

    public void Execute()
    {
        this.Stereo_.Off();
    }

    public void Undo()
    {
        this.Stereo_.On();
    }
}

public abstract class CeilingFanCommand : Command
{
    public CeilingFan Fan;
    public CeilingFan.Speeds PreviousSpeed { get; set; }

    public CeilingFanCommand(CeilingFan fan)
    {
        this.Fan = fan;
    }

    public abstract void Execute();

    public void Undo()
    {
        switch (this.PreviousSpeed)
        {
            case CeilingFan.Speeds.HIGH:
                this.Fan.High();
                break;
            case CeilingFan.Speeds.MEDIUM:
                this.Fan.Medium();
                break;
            case CeilingFan.Speeds.LOW:
                this.Fan.Low();
                break;
            case CeilingFan.Speeds.OFF:
                this.Fan.Off();
                break;
        }
    }
}

public class CeilingFanHighCommand : CeilingFanCommand
{
    public CeilingFanHighCommand(CeilingFan fan): base(fan){}
    public override void Execute()
    {
        this.PreviousSpeed = this.Fan.Speed;
        this.Fan.High();
    }
}

public class CeilingFanMediumCommand : CeilingFanCommand
{
    public CeilingFanMediumCommand(CeilingFan fan): base(fan){}
    public override void Execute()
    {
        this.PreviousSpeed = this.Fan.Speed;
        this.Fan.Medium();
    }
}

public class CeilingFanLowCommand : CeilingFanCommand
{
    public CeilingFanLowCommand(CeilingFan fan): base(fan){}
    public override void Execute()
    {
        this.PreviousSpeed = this.Fan.Speed;
        this.Fan.Low();
    }
}

public class CeilingFanOffCommand : CeilingFanCommand
{
    public CeilingFanOffCommand(CeilingFan fan): base(fan){}
    public override void Execute()
    {
        this.PreviousSpeed = this.Fan.Speed;
        this.Fan.Off();
    }
}

public class MacroCommand : Command
{
    public Command[] Commands;

    public MacroCommand(Command[] commands)
    {
        this.Commands = commands;
    }

    public void Execute()
    {
        foreach (Command command in this.Commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (Command command in this.Commands)
        {
            command.Undo();
        }
    }
}