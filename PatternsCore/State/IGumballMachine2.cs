namespace PatternsCore.State
{
    public interface IGumballMachine2
    {
        int GetCount { get; }
        IGumballState GetSoldOutState { get; }
        IGumballState GetNoQuarterState { get; }
        IGumballState GetHasQuarterState { get; }
        IGumballState GetSoldState { get; }
        IGumballState GetWinnerState { get; }
        void InsertQuarter();
        void TurnCrank();
        void SetState(IGumballState state);
        void ReleaseBall();
        string ToString();
    }
}