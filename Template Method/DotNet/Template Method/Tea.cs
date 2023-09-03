namespace Template_Method;

public class Tea : CaffeineBeverage
{
    public override void Brew() { Console.WriteLine("Steeping the tea"); }

    public override void AddCondiments() { Console.WriteLine("Adding Lemon"); }

    public override bool CondimentsNeeded()
    {
        String answer = GetUserInput();
        return answer.ToLower().StartsWith("y");
    }

    private String GetUserInput()
    {
        String? answer = null;
        Console.WriteLine("Would you like milk and sugar with your tea (y/n)? ");
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