using Ducks.FlyBehaviors;
using Ducks.QuackBehaviors;

namespace Ducks.Ducks;


public class ModelDuck : Duck
{
    private FlyBehavior _flyBehavior;
    private QuackBehavior _quackBehavior;
    public override FlyBehavior FlyConduct
    {
        get => this._flyBehavior;
        set => this._flyBehavior = (FlyBehavior)value;
    }
    public override QuackBehavior QuackConduct
    {
        get => this._quackBehavior;
        set => this._quackBehavior = (QuackBehavior)value;
    }
    public ModelDuck()
    {
        this.FlyConduct = new FlyNoWay();
        this.QuackConduct = new NormalQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model Duck");
    }
}