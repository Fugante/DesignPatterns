namespace Iterator_and_Composite;

public class MenuItem : MenuComponent
{
    public override string Name { get; }
    public override string Description { get; }
    public override bool Vegetarian { get; }
    public override double Price { get; }

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public override void Print()
    {
        Console.Write($"  {Name}");
        if (Vegetarian)
        {
            Console.Write("(v)");
        }
        Console.WriteLine($", {Price}");
        Console.WriteLine($"   -- {Description}");
    }
}