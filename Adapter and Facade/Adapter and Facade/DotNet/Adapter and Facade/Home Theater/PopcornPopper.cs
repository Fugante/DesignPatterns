namespace Adapter_and_Facade.Home_Theater;

public class PopcornPopper
{
    public void On() { Console.WriteLine("Popcorn popper on"); }

    public void Off() { Console.WriteLine("Popcorn popper off"); }

    public void Pop() { Console.WriteLine("Popping popcorns!"); }

    public override string ToString() { return "PopcornPopper"; }
}
