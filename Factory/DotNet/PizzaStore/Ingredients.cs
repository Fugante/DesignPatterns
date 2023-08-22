namespace PizzaStore;


// INGREDIENT BASE CLASSES

public abstract class Dough
{
    public abstract String Name { get; set; }
}

public abstract class Sauce
{
    public abstract String Name { get; set; }
}

public abstract class Cheese
{
    public abstract String Name { get; set; }
}

public abstract class Veggies
{
    public abstract String Name { get; set; }
}

public abstract class Pepperoni
{
    public abstract String Name { get; set; }
}

public abstract class Clams
{
    public abstract String Name { get; set; }
}

// CONCRETE INGREDIENTS

public class ThinCrustDough : Dough
{
    public override String Name { get; set; } = "Thin Crust Dough";
}

public class MarinaraSauce : Sauce
{
    public override String Name { get; set; } = "Marinara Sauce";
}

public class ReggianoCheese : Cheese
{
    public override String Name { get; set; } = "Reggiano Cheese";
}

public class Garlic : Veggies
{
    public override String Name { get; set; } = "Garlic";
}

public class Onion : Veggies
{
    public override String Name { get; set; } = "Onion";
}

public class Mushroom : Veggies
{
    public override String Name { get; set; } = "Mushroom";
}

public class RedPepper : Veggies
{
    public override String Name { get; set; } = "RedPepper";
}

public class SlicedPepperoni : Pepperoni
{
    public override String Name { get; set; } = "SlicedPepperoni";
}

public class FreshClams : Clams
{
    public override String Name { get; set; } = "FreshClams";
}


// INGREDIENT FACTORIES

public interface PizzaIngredientFactory
{
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    List<Veggies> CreateVeggies();
    Pepperoni CreatePepperoni();
    Clams CreateClam();
}

public class NYPizzaIngredientFactory : PizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public List<Veggies> CreateVeggies()
    {
        List<Veggies> veggies = new();
        veggies.Add(new Garlic());
        veggies.Add(new Onion());
        veggies.Add(new Mushroom());
        veggies.Add(new RedPepper());
        return veggies;
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClam()
    {
        return new FreshClams();
    }
}

