using System;

namespace PatternsCore.Proxy
{
    /// <summary>
    /// Virtual proxy
    /// </summary>
    public class ProxySubject :ISubject
    {
        private ISubject _realRealSubject;

        public void DoSomething()
        {
            //delegating the task
            //Lazy loading 
            //why we need proxies?
            //to provide security 
            //to manage
            //to access a remote resource etc
            _realRealSubject= new RealSubject();

            Console.WriteLine("I am proxy now i am decorating real subject.... calling realsubject");
            _realRealSubject.DoSomething();

        }
    }
}