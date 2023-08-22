using Ducks.Ducks;
using Ducks.FlyBehaviors;
using Ducks.QuackBehaviors;

namespace Ducks.Ducks;


public class MallardDuck : Duck
{
    private FlyWithWings _flyBehavior;
    private NormalQuack _quackBehavior;
    public override FlyBehavior FlyConduct
    {
        get => this._flyBehavior;
        set => this._flyBehavior = (FlyWithWings)value;
    }
    public override QuackBehavior QuackConduct
    {
        get => this._quackBehavior;
        set => this._quackBehavior = (NormalQuack)value;
    }

    public MallardDuck()
    {
        this.FlyConduct = new FlyWithWings();
        this.QuackConduct = new NormalQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}