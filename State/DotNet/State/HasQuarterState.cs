namespace State;

public class HasQuarterState : State
{
    private Random Random = new Random();
    private GumballMachine GumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        GumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        GumballMachine.State = GumballMachine.NoQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        int winner = Random.Next(10);
        if (winner == 0 && GumballMachine.Count > 1)
        {
            GumballMachine.State = GumballMachine.WinnerState;
        }
        else
        {
            GumballMachine.State = GumballMachine.SoldState;
        }
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void Refill() { }
}
