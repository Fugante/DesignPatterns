namespace State;

public class SoldOutState : State
{
    private GumballMachine GumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        GumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Sorry we're are sold out");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter yet");
    }

    public void TurnCrank()
    {
        Console.WriteLine("There are no gumballs left");
    }

    public void Dispense()
    {
        GumballMachine.ReleaseBall();
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

    public void Refill()
    {
        GumballMachine.State = GumballMachine.NoQuarterState;
    }
}
