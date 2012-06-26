namespace PatternsCore.State
{
    //NOTE state pattern is trying to resolve the problem below
    //NOTE without state pattern how things look like
    public class GumballMachine
    {
        public const int Soldout = 0;
        public const int NoQuarter = 1;
        public const int HasQuarter = 2;
        public const int Sold = 3;
        private int _state = Soldout;
        private int _count;

        public GumballMachine(int count)
        {
            if (count>0)
            {
                _count = count;
                _state = NoQuarter;            
            }
        }

        public  void InsertQuarter()
        {
            switch (_state)
            {
                case HasQuarter:
                    System.Console.WriteLine("you cant insert another quarter");break;
                case NoQuarter:
                    _state = HasQuarter;
                    System.Console.WriteLine("you inserted a quarter");
                    break;
                case Soldout:
                    System.Console.WriteLine("you cant insert a quarter, the machine is sold out");break;
                case Sold:
                    System.Console.WriteLine("Please wait we are giving you a gumball");break;
            }
        }

        public void EjectQuarter()
        {
            switch (_state)
            {
                case HasQuarter:
                    System.Console.WriteLine("Quarter returned");
                    _state = NoQuarter;
                    break;
                case NoQuarter:
                    System.Console.WriteLine("you havn't inserted a quarter");break;
                case Soldout:
                    System.Console.WriteLine("you cant eject you havnt inserted a quarter");break;
                case Sold:
                    System.Console.WriteLine("Sorry you already turned the crank");break;
            }
        }
        public void TurnCrank()
        {
            switch (_state)
            {
                case HasQuarter:
                    System.Console.WriteLine("you turned");
                    _state = Sold;
                    Dispense();
                    break;
                case NoQuarter:
                    System.Console.WriteLine("You turned but there is no qurter");break;
                case Soldout:
                    System.Console.WriteLine("you turned but there is no gumball");break;
                case Sold:
                    System.Console.WriteLine("Turning twice wont give you another gumball!");break;
            }
        }

        public void Dispense()
        {
            switch (_state)
            {
                case NoQuarter:
                    System.Console.WriteLine("Please pay first");break;
                case Sold:
                    System.Console.WriteLine("Gumball comes out the slot");
                    _count = _count - 1;
                    if(_count == 0)
                    {
                        System.Console.WriteLine("oops out of Gumball");
                        _state = Soldout;
                    }
                    else
                        _state = NoQuarter;
                    break;
                default:
                    System.Console.WriteLine("no gumball dispensed");break;
            }       
        }

        public override string ToString()
        {
            return
                (
                    string.Format("\nGumball Machine, Inventory is {0} gumballs,  ",  _count) +
                    (
                        "Machine is in " + (
                                                _state == 0 ? "Sold out": _state == 1 ? "no quarter" : _state == 2 ? "has quarter" : "sold"
                                            ) + 
                        " state\n"
                    )
                );
        }
    }
}