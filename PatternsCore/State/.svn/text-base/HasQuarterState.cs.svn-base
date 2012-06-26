using System;

namespace PatternsCore.State
{
    public class HasQuarterState : IGumballState
    {
        private readonly IGumballMachine2 _gumballMachine;
        private readonly Random _randomWinner;
        public HasQuarterState(IGumballMachine2 gumballMachine2)
        {
            _gumballMachine = gumballMachine2;
            _randomWinner= new Random(DateTime.Now.Millisecond);
        }

        public void InsertQuarter()
            {Console.WriteLine("you cant insert another quarter");}

        public void EjectQuarter()
        {
            Console.WriteLine("quarter Returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("you turned");
            int winner = _randomWinner.Next(10);
            //System.Console.WriteLine("\n" + winner +"\n");
            if(winner%2==0 && _gumballMachine.GetCount>1)
                _gumballMachine.SetState(_gumballMachine.GetWinnerState);
            else
                _gumballMachine.SetState(_gumballMachine.GetSoldState);
        }

        public void Dispense()
            { Console.WriteLine("no gumball dispensed"); }

        public override string ToString()
            { return string.Format("HasQuarter"); }
    }
}