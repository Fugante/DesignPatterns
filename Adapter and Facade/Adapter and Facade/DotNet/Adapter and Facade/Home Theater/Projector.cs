namespace Adapter_and_Facade.Home_Theater;

public class Projector
{
    public StreamingPlayer Player;

    public Projector(StreamingPlayer player)
    {
        Player = player;
    }

    public void On() { Console.WriteLine("Proyector on"); }

    public void Off() { Console.WriteLine("Proyector off"); }

    public void TvMode() { Console.WriteLine("TV mode"); }

    public void WideScreenMode() { Console.WriteLine("Wide screen mode"); }

    public override string ToString() { return $"Proyector({Player})"; }
}
