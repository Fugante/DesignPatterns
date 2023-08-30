namespace Adapter_and_Facade.Home_Theater;

public class StreamingPlayer
{
    public Amplifier Amplifier;

    public StreamingPlayer(Amplifier amplifier)
    {
        Amplifier = amplifier;
    }

    public void On() { Console.WriteLine("StreamingPlayer on"); }

    public void Off() { Console.WriteLine("StreamingPlayer off"); }

    public void Pause() { Console.WriteLine("StreamingPlayer paused"); }

    public void Play(string movie) { Console.WriteLine($"Playing {movie}"); }

    public void SetSurroundAudio() { Console.WriteLine("StreamingPlayer audio set"); }

    public void SetTwoChannedAudio() { Console.WriteLine("Two channed audio set"); }

    public void Stop() { Console.WriteLine("StreamingPlayer stopped"); }

    public override string ToString() { return $"StreamingPlayer({Amplifier})"; }
}