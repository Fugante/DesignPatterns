using Adapter_and_Facade.Ducks;
using Adapter_and_Facade.Home_Theater;
using Adapter_and_Facade.Turkeys;
using System.Numerics;

namespace Adapter_and_Facade;

public class TurkeyAdapter : IDuck
{
    public ITurkey Turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        Turkey = turkey;
    }

    public void Quack()
    {
        Turkey.Gobble();
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            Turkey.Fly();
        }
    }
}

public class DuckAdapter : ITurkey
{
    public IDuck Duck;

    public DuckAdapter(IDuck duck)
    {
        Duck = duck;
    }

    public void Gobble()
    {
        Duck.Quack();
    }

    public void Fly()
    {
        Duck.Fly();
    }
}

public class HomeTheaterFacade
{
    public Amplifier Amplifier;
    public Tuner Tuner;
    public StreamingPlayer Player;
    public Projector Projector;
    public TheaterLights Lights;
    public Screen Screen;
    public PopcornPopper Popper;

    public HomeTheaterFacade(
        Amplifier amplifier,
        Tuner tuner,
        StreamingPlayer player,
        Projector proyector,
        Screen screen,
        TheaterLights lights,
        PopcornPopper popper
    )
    {
        Amplifier = amplifier;
        Tuner = tuner;
        Player = player;
        Projector = proyector;
        Lights = lights;
        Screen = screen;
        Popper = popper;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        Popper.On();
        Popper.Pop();
        Lights.Dim(10);
        Screen.Down();
        Projector.On();
        Projector.WideScreenMode();
        Amplifier.On();
        Amplifier.Player = Player;
        Amplifier.SetSurroundSound();
        Amplifier.Volume = 5;
        Player.On();
        Player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        Popper.Off();
        Lights.On();
        Screen.Up();
        Projector.Off();
        Amplifier.Off();
        Player.Stop();
        Player.Off();
    }
}