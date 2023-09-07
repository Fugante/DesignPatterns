namespace State;

public class WinnerState : State
{
    private GumballMachine GumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
        GumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
        GumballMachine.State = GumballMachine.SoldState;
    }

    public void Dispense()
    {
        GumballMachine.ReleaseBall();
        if (GumballMachine.Count == 0)
        {
            GumballMachine.State = GumballMachine.SoldOutState;
            return;
        }

        GumballMachine.ReleaseBall();
        Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
        if (GumballMachine.Count > 0)
        {
            GumballMachine.State = GumballMachine.NoQuarterState;
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            GumballMachine.State = GumballMachine.SoldOutState;
        }
    }

    public void Refill() { }
}
