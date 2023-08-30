namespace Adapter_and_Facade.Home_Theater;

public class Tuner
{
    public Amplifier Amplifier;

    public Tuner(Amplifier amplifier)
    {
        Amplifier = amplifier;
    }

    public void On() { Console.WriteLine("Tuner on"); }

    public void Off() { Console.WriteLine("Tuner off"); }

    public void SetAm() { Console.WriteLine("AM mode"); }

    public void SetFm() { Console.WriteLine("FM mode"); }

    public void SetFrequency() { Console.WriteLine("Setting frequency..."); }

    public override string ToString() { return $"Tuner({Amplifier})"; }
}
