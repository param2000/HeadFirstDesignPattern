using System;

namespace PatternsCore.State
{
    public class SoldState : IGumballState
    {
        private readonly IGumballMachine2 _gumballMachine;

        public SoldState(IGumballMachine2 gumballMachine)
            {_gumballMachine = gumballMachine;}

        public void InsertQuarter()
            {Console.WriteLine(("Please wait we are giving you a gumball"));}

        public void EjectQuarter()
            {Console.WriteLine("Sorry you already turned the crank");}

        public void TurnCrank()
            {Console.WriteLine("Turning twice does not give you another gumball()");}

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if(_gumballMachine.GetCount>0)
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState);
            else
            {
                Console.WriteLine("oops out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState);
            }
        }

        public override string ToString()
        { return string.Format("SoldState"); }
    }
}