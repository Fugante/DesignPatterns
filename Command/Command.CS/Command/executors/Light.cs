namespace CommandPattern.Executors;


public class Light
{
    public string Name { get; }

    public Light(string name)
    {
        this.Name = name;
    }

    public void On()
    {
        Console.WriteLine($"{this.Name} is on");
    }
    public void Off()
    {
        Console.WriteLine($"{this.Name} is off");
    }
}