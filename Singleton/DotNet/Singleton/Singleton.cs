namespace Singleton;


public class UnsafeSingleton
{
    private static UnsafeSingleton UniqueInstance = null;
    public String Name { get; } = "Unsafe Singleton";

    private UnsafeSingleton(){}

    public static UnsafeSingleton GetInstance()
    {
        if (UniqueInstance is null)
            UniqueInstance = new();
        return UniqueInstance;
    }
}

public class EagerSingleton
{
    private static EagerSingleton UniqueInstance = new();
    public String Name { get; } = "Eager Singleton";

    private EagerSingleton(){}

    public static EagerSingleton GetInstance()
    {
        return UniqueInstance;
    }
}