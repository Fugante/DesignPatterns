namespace Starbuzz;


enum BeverageSize
{
    TALL,
    GRANDE,
    VENTI
}


public abstract class Beverage
{
    public virtual BeverageSize Size { get; set; }
    public virtual String Description { get; } = "Unknown";
    public virtual double Cost { get; }
}

public abstract class CondimentDecorator : Beverage
{
    protected virtual Beverage Beverage_ { get; set; }
    public CondimentDecorator(Beverage beverage)
    {
        this.Beverage_ = beverage;
    }
}


// Beverages

public class Espresso : Beverage
{
    public override String Description { get; } = "Espresso";
    public override double Cost { get; } = 1.99;
}

public class HouseBlend : Beverage
{
    public override String Description { get; } = "House Blend Coffee";
    public override double Cost { get; } = 0.89;
}

public class DarkRoast : Beverage
{
    public override String Description { get; } = "Dark Roast";
    public override double Cost { get; } = 0.99;
}

public class Decaf : Beverage
{
    public override String Description { get; } = "Decaf";
    public override double Cost { get; } = 1.05;
}


// Condiments

public class Mocha : CondimentDecorator
{
    public override String Description
    {
        get => this.Beverage_.Description + ", Mocha";
    }
    public override double Cost
    {
        get => this.Beverage_.Cost + 0.20;
    }

    public Mocha(Beverage beverage) : base(beverage){}
}

public class Soy : CondimentDecorator
{
    public override String Description
    {
        get => this.Beverage_.Description + ", Soy";
    }
    public override double Cost
    {
        get => this.Beverage_.Cost + 0.15;
    }

    public Soy(Beverage beverage) : base(beverage){}
}

public class Whip : CondimentDecorator
{
    public override String Description
    {
        get => this.Beverage_.Description + ", Whip";
    }
    public override double Cost
    {
        get => this.Beverage_.Cost + 0.10;
    }

    public Whip(Beverage beverage) : base(beverage){}
}