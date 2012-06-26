using System;

namespace PatternsCore.Proxy
{
    public  class RealSubject:ISubject
    {
        public void DoSomething()
        {Console.WriteLine("I am doing something usefull, I am real Subject");}
    }
}