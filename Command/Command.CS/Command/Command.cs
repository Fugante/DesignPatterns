using CommandPattern.Executors;
namespace CommandPattern;


public interface Command
{
    void Execute();
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
}

public class GarageDoorOpenCommand : Command
{
    public GarageDoor Door;

    public GarageDoorOpenCommand(GarageDoor door)
    {
        this.Door = door;
    }

    public void Execute()
    {
        this.Door.Up();
    }
}