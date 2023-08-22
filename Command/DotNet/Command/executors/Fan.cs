namespace CommandPattern.Executors;


public class CeilingFan
{
    public enum Speeds
    {
        HIGH = 3,
        MEDIUM = 2,
        LOW = 1,
        OFF = 0,
    };
    public string Name { get; set; }
    public Speeds Speed { get; set; } = Speeds.OFF;

    public CeilingFan(string name)
    {
        this.Name = name;
    }

    public void High()
    {
        this.Speed = Speeds.HIGH;
    }

    public void Medium()
    {
        this.Speed = Speeds.MEDIUM;
    }

    public void Low()
    {
        this.Speed = Speeds.LOW;
    }

    public void Off()
    {
        this.Speed = Speeds.OFF;
    }
}