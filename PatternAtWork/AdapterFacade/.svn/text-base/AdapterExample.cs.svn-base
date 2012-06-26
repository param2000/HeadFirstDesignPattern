using System;
using PatternsCore.Adapter;

namespace PatternAtWork.AdapterFacade
{
    public class AdapterExample
    {
        public AdapterExample()
        {

            IDuck mallardDuck = new MallardDuck();

            ITurkey wildTurkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);


            Console.WriteLine("Testing Turkey.......");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("Testing Duck.......");
            mallardDuck.Quack();
            mallardDuck.Fly();

            Console.WriteLine("Testing Adapter.......");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}