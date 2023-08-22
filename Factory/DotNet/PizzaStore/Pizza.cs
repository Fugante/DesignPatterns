namespace PizzaStore;


public abstract class Pizza
{
    public String Name { get; set; }
    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public List<Veggies> Veggies { get; } = new();
    public Cheese Cheese { get; set; }
    public Pepperoni Pepperoni { get; set; }
    public Clams Clam { get; set; }

    public abstract void Prepare();

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}

public class CheesePizza : Pizza
{
    private PizzaIngredientFactory IngredientFactory { get; }

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
    {
        this.IngredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {this.Name}");
        this.Dough = this.IngredientFactory.CreateDough();
        this.Sauce = this.IngredientFactory.CreateSauce();
        this.Cheese = this.IngredientFactory.CreateCheese();
    }
}

public class ClamPizza : Pizza
{
    private PizzaIngredientFactory IngredientFactory { get; }

    public ClamPizza(PizzaIngredientFactory ingredientFactory)
    {
        this.IngredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {this.Name}");
        this.Dough = this.IngredientFactory.CreateDough();
        this.Sauce = this.IngredientFactory.CreateSauce();
        this.Cheese = this.IngredientFactory.CreateCheese();
        this.Clam = this.IngredientFactory.CreateClam();
    }
}