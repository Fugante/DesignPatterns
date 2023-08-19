namespace CommandPattern.Executors;


public class GarageDoor
{
    public void Up()
    {
        Console.WriteLine("Garage door is open");
    }

    public void Down()
    {
        Console.WriteLine("Garage door is closed");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping action");
    }

    public void LightOn()
    {
        Console.WriteLine("Garage door light is on");
    }

    public void LightOff()
    {
        Console.WriteLine("Garage door light is off");
    }
}