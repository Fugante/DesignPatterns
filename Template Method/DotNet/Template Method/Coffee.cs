using System;

namespace Template_Method;

public class Coffee : CaffeineBeverage
{
    public override void Brew() { Console.WriteLine("Dripping Coffee through filter"); }

    public override void AddCondiments() { Console.WriteLine("Adding Sugar and Milk"); }

    public override bool CondimentsNeeded()
    {
        String answer = GetUserInput();
        return answer.ToLower().StartsWith("y");
    }

    private String GetUserInput()
    {
        String? answer = null;
        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
        try
        {
            answer = Console.ReadLine();
        }
        catch (Exception e) when (e is IOException || e is OutOfMemoryException)
        {
            Console.Error.WriteLine("IO error trying to read your answer");
        }
        if (answer is null)
        {
            answer = "no";
        }
        return answer;
    }
}