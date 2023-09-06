namespace Iterator_and_Composite;

public class Menu : MenuComponent
{
    private List<MenuComponent> MenuComponents = new();
    public override string Name { get; }
    public override string Description { get; }

    public Menu(string name, string  description)
    {
        Name = name;
        Description = description;
    }

    public override void Add(MenuComponent menuComponent)
    {
        MenuComponents.Add(menuComponent);
    }

    public override MenuComponent GetChild(int index)
    {
        return MenuComponents[index];
    }

    public override void Print()
    {
        Console.Write($"\n{Name}");
        Console.WriteLine($", {Description}");
        Console.WriteLine("---------------------");

        foreach (MenuComponent menuComponent in MenuComponents)
        {
            menuComponent.Print();
        }
    }
}
