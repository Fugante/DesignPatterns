namespace State;

public interface State
{
    public void InsertQuarter();
    public void EjectQuarter();
    public void TurnCrank();
    public void Dispense();
    public void Refill();
}
