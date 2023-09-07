namespace State;

public class GumballMachine
{
    public State SoldOutState;
    public State NoQuarterState;
    public State HasQuarterState;
    public State SoldState;
    public State WinnerState;
    public State State { get; set; }
    public int Count { get; set; } = 0;

    public GumballMachine(int numberGumballs)
    {
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        WinnerState = new WinnerState(this);

        Count = numberGumballs;
        if (numberGumballs > 0)
        {
            State = NoQuarterState;
        }
        else
        {
            State = SoldOutState;
        }
    }

    public void InsertQuarter()
    {
        State.InsertQuarter();
    }

    public void EjectQuarter()
    {
        State.EjectQuarter();
    }

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense();
    }

    public void Refill(int count)
    {
        Count += count;
        Console.WriteLine(
            $"The gumball machine was just refilled; its new count is: {Count}"
        );
        State.Refill();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (Count > 0)
        {
            Count -= 1;
        }
    }

    public override string ToString()
    {
        string message = "Mighty Gumball, Inc.\n";
        message += "Standing Gumball Model #2004\n";
        message += $"Inventory: {Count} gumballs\n";
        if (State == HasQuarterState)
        {
            message += "Machine is waiting for quarter";
        }
        else if (State == NoQuarterState)
        {
            message += "Machine is waiting for action: turn crank or eject quarter";
        }
        else if (State == SoldOutState)
        {
            message += "Machine is sold out";
        }
        else if (State == SoldState)
        {
            message += "Machine is dispensing gumball";
        }
        message += "\n";
        return message;
    }
}