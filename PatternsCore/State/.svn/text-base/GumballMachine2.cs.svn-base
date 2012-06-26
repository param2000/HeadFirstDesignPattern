namespace PatternsCore.State
{
    public class GumballMachine2 : IGumballMachine2
    {
        private readonly IGumballState _soldOutState;
        private readonly IGumballState _noQuarterState;
        private readonly IGumballState _hasQuarterState;
        private readonly IGumballState _soldState;
        private readonly IGumballState _winnerState;

        private IGumballState _state;
        private int _count;
        
        public GumballMachine2(int gumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            
            _count = gumballs;
            if (gumballs > 0)
                _state = _noQuarterState;
        }

        public int GetCount
            {get { return _count; }}

        public void InsertQuarter()
            {_state.InsertQuarter();}

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IGumballState state)
            {_state = state;}

        public void ReleaseBall()
        {
            System.Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
            {
                _count = _count - 1;
                
            }
        }

        public IGumballState GetSoldOutState
            {get { return _soldOutState; }}

        public IGumballState GetNoQuarterState
            {get { return _noQuarterState; }}

        public IGumballState GetHasQuarterState
            {get { return _hasQuarterState; }}

        public IGumballState GetSoldState
            {get { return _soldState; }}

        public IGumballState GetWinnerState
            {get { return _winnerState; }}

        public override string ToString()
        {
            return string.Format("Gumball has Count: {0} gumballs, and is in {1} state", _count, _state);
        }
    }
}