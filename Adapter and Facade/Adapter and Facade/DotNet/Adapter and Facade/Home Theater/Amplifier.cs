namespace Adapter_and_Facade.Home_Theater;

public class Amplifier
{
    public Tuner Tuner { get; set; }
    public StreamingPlayer Player { get; set; }
    public int Volume { get; set; } = 0;
 
    public void On() { Console.WriteLine("Amplifier on"); }

    public void Off() { Console.WriteLine("Amplifier off"); }

    public void SetStereoSound() { Console.WriteLine("Stereo sound"); }

    public void SetSurroundSound() { Console.WriteLine("Surround sound"); }

    public override string ToString() { return $"Amplifier({Tuner}, {Player})"; }
}
