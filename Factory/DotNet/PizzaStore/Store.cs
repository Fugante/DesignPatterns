namespace PizzaStore;


public abstract class PizzaStore
{
    public Pizza OrderPizza(String type)
    {
        Pizza pizza;
        pizza = this.CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    protected abstract Pizza CreatePizza(String type);
}

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(String type)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if (type == "cheese")
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        }
        // else if (type == "veggie")
        //     return new NYStyleVeggiePizza();
        // else if (type == "clam")
        //     return new NYStyleClamPizza();
        // else if (type == "pepperoni")
        //     return new NYStylePepperoniPizza();
        return pizza;
    }
}

// public class ChicagoPizzaStore : PizzaStore
// {
//     protected override Pizza CreatePizza(String type)
//     {
//         if (type == "cheese")
//             return new ChicagoStyleCheesePizza();
//         // else if (type == "veggie")
//         //     return new NYStyleVeggiePizza();
//         // else if (type == "clam")
//         //     return new NYStyleClamPizza();
//         // else if (type == "pepperoni")
//         //     return new NYStylePepperoniPizza();
//         else return null;
//     }
// }