namespace CommandPattern.Executors;


public class Stereo
{
    public string Name { get; set; }

    public Stereo(string name)
    {
        this.Name = $"{name} stereo";
    }

    public void On()
    {
        Console.WriteLine($"{this.Name} is on");
    }

    public void Off()
    {
        Console.WriteLine($"{this.Name} is off");
    }

    public void SetCd()
    {
        Console.WriteLine($"{this.Name} is set for CD input");
    }

    public void SetDvd()
    {
        Console.WriteLine($"{this.Name} is set for DVD input");
    }

    public void SetRadio()
    {
        Console.WriteLine($"{this.Name} is set to radio");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"{this.Name} volume set to {volume}");
    }
}