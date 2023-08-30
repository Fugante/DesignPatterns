﻿namespace Adapter_and_Facade.Ducks;

public interface IDuck
{
    public void Quack();
    public void Fly();
}

public class MallardDuck : IDuck
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}