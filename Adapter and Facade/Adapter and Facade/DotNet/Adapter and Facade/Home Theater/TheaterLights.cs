namespace Adapter_and_Facade.Home_Theater;

public class TheaterLights
{
    public int Intensity { get; set; } = 0;

    public void On() { Console.WriteLine("Theater lights on"); }

    public void Off() { Console.WriteLine("Theater lights off"); }

    public void Dim(int intensity) { Intensity = intensity; }

    public override string ToString() { return "TheaterLights"; }
}