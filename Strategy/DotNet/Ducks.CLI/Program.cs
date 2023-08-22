using Ducks.Ducks;
using Ducks.FlyBehaviors;

namespace Ducks.CLI;

public class MiniDuckSimulator
{
    public static void Main()
    {
        MallardDuck duck = new();
        duck.PerformQuack();
        duck.PerformFly();

        ModelDuck model = new();
        model.PerformFly();
        model.FlyConduct = new FlyRocketPowered();
        model.PerformFly();
    }
}