using Singleton;

public class Program
{
    public static void Main()
    {
        UnsafeSingleton unsafeSingleton = UnsafeSingleton.GetInstance();
        Console.WriteLine($"{unsafeSingleton.Name}");

        EagerSingleton eagerSingleton = EagerSingleton.GetInstance();
        Console.WriteLine($"{eagerSingleton.Name}");
    }
}