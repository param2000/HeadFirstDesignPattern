using System;

namespace PatternsCore.State
{
    public class  NoQuarterState:IGumballState
    {
        private readonly IGumballMachine2 _gumballMachine;

        public NoQuarterState(IGumballMachine2 gumballMachine)
            {_gumballMachine = gumballMachine;}

        public void InsertQuarter()
        {
            Console.WriteLine("you Inserted a Quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState);
        }

        public void EjectQuarter()
            {Console.WriteLine("you havnt inserted a quarter");}

        public void TurnCrank()
            {Console.WriteLine("you turned but there is no quarter");}

        public void Dispense()
            {Console.WriteLine("you need to pay first");}


        public override string ToString()
        { return string.Format("NoQuarter"); }
    }
}