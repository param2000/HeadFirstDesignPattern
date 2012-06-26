
using PatternsCore.State;

namespace PatternAtWork.State
{
    public class StateExample
    {
        //problem state pattern is trying to solve
        public StateExample()
        {
            var gumballMachine= new GumballMachine(5);

            System.Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            System.Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();
            System.Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            System.Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            System.Console.WriteLine(gumballMachine);
            
        }

        //example with state pattern
        public StateExample(int i)
        {
            var gumballMachine = new GumballMachine2(5);
            
            System.Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            //System.Console.WriteLine(gumballMachine);
            gumballMachine.TurnCrank();

            System.Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();

            //System.Console.WriteLine(gumballMachine);
            gumballMachine.TurnCrank();

            //System.Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();

            //System.Console.WriteLine(gumballMachine);
            gumballMachine.TurnCrank();

            System.Console.WriteLine(gumballMachine);
        }
    }
}