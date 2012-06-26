namespace PatternsCore.State
{
    public interface IGumballState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();  
    }
}