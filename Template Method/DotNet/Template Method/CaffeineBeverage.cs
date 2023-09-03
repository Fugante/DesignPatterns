namespace Template_Method;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CondimentsNeeded())
        {
            AddCondiments();
        }
    }

    public abstract void Brew();

    public abstract void AddCondiments();

    public void BoilWater() { Console.WriteLine("Boiling water"); }

    public void PourInCup() { Console.WriteLine("Pouring into cup"); }

    public virtual bool CondimentsNeeded() { return true; }
}