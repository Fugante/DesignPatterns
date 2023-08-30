namespace Adapter_and_Facade.Home_Theater;

public class Screen
{
    public void Up() { Console.WriteLine("Screen is up"); }

    public void Down() { Console.WriteLine("Screen is down"); }

    public override string ToString() { return "Screen"; }
}