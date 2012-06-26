namespace PatternsCore.State
{
    public class SoldOutState : IGumballState
    {
        public SoldOutState(IGumballMachine2 gumballMachine)
            {}

        public void InsertQuarter()
            {System.Console.WriteLine("you cant insert a quarter, the machine is sold out");}

        public void EjectQuarter()
            {System.Console.WriteLine("you cant eject you havent inserted a quarter");}

        public void TurnCrank()
            {System.Console.WriteLine("you turned but there is no gumball");}

        public void Dispense()
            {System.Console.WriteLine("no gumball dispensed");}


        public override string ToString()
        { return string.Format("SoldOut"); }
    }
}