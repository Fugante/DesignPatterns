using PS = PizzaStore;


public class PizzaTestDrive
{
    public static void Main()
    {
        PS.PizzaStore nyStore = new PS.NYPizzaStore();
        // PS.PizzaStore chigagoStore = new PS.ChicagoPizzaStore();

        PS.Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

        // pizza = chigagoStore.OrderPizza("cheese");
        // Console.WriteLine($"Joel ordered a {pizza.Name}\n");
    }
}