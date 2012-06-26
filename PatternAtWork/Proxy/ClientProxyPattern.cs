using PatternsCore.Proxy;

namespace PatternAtWork.Proxy
{
    /*
     * Adapter provides a different interface to its subject. Proxy provides the same interface. Decorator provides an enhanced interface.
     * Decorator and Proxy have different purposes but similar structures. 
     * Both describe how to provide a level of indirection to another object, and the implementations keep a reference to the object to which they forward requests.
     * Examples Remote Proxy, 
     * virtual proxy (controls the resource that is very expensive to create
     * protection proxy control access to the resource
     * 
     */
    public class ClientProxyPattern
    {
        public ClientProxyPattern()
        {
            ISubject proxy = new ProxySubject(); //you container can be tuned to always give proxy object for ISubject
            proxy.DoSomething();



        }
    }
}