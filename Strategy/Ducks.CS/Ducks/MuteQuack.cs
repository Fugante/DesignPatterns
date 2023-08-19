namespace Ducks.QuackBehaviors;


public class MuteQuack : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}