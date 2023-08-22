using Ducks.FlyBehaviors;
using Ducks.QuackBehaviors;

namespace Ducks.Ducks;


public abstract class Duck
{
    public abstract FlyBehavior FlyConduct { get; set; }
    public abstract QuackBehavior QuackConduct { get; set; }

    public Duck(){}

    public abstract void Display();

    public void PerformFly()
    {
        this.FlyConduct.Fly();
    }

    public void PerformQuack()
    {
        this.QuackConduct.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}