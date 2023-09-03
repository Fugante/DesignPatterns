using Template_Method;

public class BeverageTestDrive
{
    public static void Main()
    {
        Tea tea = new Tea();
        Coffee coffee = new();

        Console.WriteLine("\nMaking Tea...");
        tea.PrepareRecipe();

        Console.WriteLine("\nMaking Coffee...");
        coffee.PrepareRecipe();
    }
}