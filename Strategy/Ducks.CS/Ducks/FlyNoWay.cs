namespace Ducks.FlyBehaviors;


public class FlyNoWay : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}