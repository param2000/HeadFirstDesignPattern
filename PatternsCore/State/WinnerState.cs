using System;

namespace PatternsCore.State
{
    public class WinnerState : IGumballState
    {
        private readonly IGumballMachine2 _gumballMachine;

        public WinnerState(IGumballMachine2 gumballMachine)
            {_gumballMachine = gumballMachine;}

        public void InsertQuarter()
            {Console.WriteLine("Please wait we are already giving you a gumball");}

        public void EjectQuarter()
            {Console.WriteLine("Sorry you already turned the crank");}

        public void TurnCrank()
            {Console.WriteLine("turning twice doesn't get you another gumball");}

        public void Dispense()
        {
            Console.WriteLine("Congrats you are the winner, you get two gumballs for your quarter");
            _gumballMachine.ReleaseBall();
            if(_gumballMachine.GetCount==0)
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState);
            else
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
        }

        public override string ToString()
            {return string.Format("Winner ");}
    }
}