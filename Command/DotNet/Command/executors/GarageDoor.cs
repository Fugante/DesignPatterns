namespace CommandPattern.Executors;


public class GarageDoor
{
    public string Name { get; }

    public GarageDoor(string name)
    {
        this.Name = $"{name} door";
    }
    public void Up()
    {
        Console.WriteLine($"{this.Name} is open");
    }

    public void Down()
    {
        Console.WriteLine($"{this.Name} is closed");
    }

    public void Stop()
    {
        Console.WriteLine($"{this.Name} stopping action");
    }

    public void LightOn()
    {
        Console.WriteLine($"{this.Name} light is on");
    }

    public void LightOff()
    {
        Console.WriteLine($"{this.Name} light is off");
    }
}