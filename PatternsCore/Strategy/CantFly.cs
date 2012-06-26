using System;

namespace PatternsCore.Strategy
{
    public class CantFly:IFly
    {
        public void Fly()
        {
            Console.WriteLine("I cant Fly");
        }
    }
}