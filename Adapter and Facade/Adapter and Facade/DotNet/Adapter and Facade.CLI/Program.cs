using Adapter_and_Facade.Ducks;
using Adapter_and_Facade.Turkeys;
using Adapter_and_Facade;
using Adapter_and_Facade.Home_Theater;
using System.Numerics;

//public class DuckTestDrive
//{
//    public static void Main()
//    {
//        IDuck duck = new MallardDuck();
//
//        ITurkey turkey = new WildTurkey();
//        IDuck turkeyAdapter = new TurkeyAdapter(turkey);
//
//        Console.WriteLine("The Turkey says...");
//        turkey.Gobble();
//        turkey.Fly();
//
//        Console.WriteLine("\nThe Duck says...");
//        TestDuck(duck);
//
//        Console.WriteLine("\nThe TurkeyAdapter says...");
//        TestDuck(turkeyAdapter);
//    }
//
//    public static void TestDuck(IDuck duck)
//    {
//        duck.Quack();
//        duck.Fly();
//    }
//}

public class HomeTheaterTestDrive
{
    public static void Main()
    {
        Amplifier amplifier = new();
        Tuner tuner = new(amplifier);
        StreamingPlayer player = new(amplifier);
        amplifier.Tuner = tuner;
        amplifier.Player = player;
        Projector projector = new(player);
        Screen screen = new();
        TheaterLights lights = new();
        PopcornPopper popper = new();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(
            amplifier, tuner, player, projector, screen, lights, popper
        );
        homeTheater.WatchMovie("Raiders of the Lost Ark");
        homeTheater.EndMovie();
    }
}