using System;
using PatternAtWork.AdapterFacade;
using PatternAtWork.Composite;
using PatternAtWork.Factory;
using PatternAtWork.Proxy;
using PatternAtWork.Singleton;
using PatternAtWork.State;
using PatternAtWork.Strategy;
using PatternsCore.Iterator;
using PatternsCore.WithoutIterator;
using DinerMenu = PatternsCore.Iterator.DinerMenu;
using PancakeHouseMenu = PatternsCore.Iterator.PancakeHouseMenu;


namespace PatternAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple factory is just programming IDIOM
          // var simpleFactory = new SimpleFatoryProgrammingIdiom();

            //factory pattern
            //var factory = new FactoryPattern();


           //abstract factory pattern
            //var factory = new AbstractFactoryPattern();
            //var factory = new AbstractFactoryPattern2();

            //another example
            //var factory = new CarExampleAbstractFactory();


            //singleton example 
           //SingletonExample singletonAtPlat= new SingletonExample();



            //Adapter
            //AdapterExample temp= new AdapterExample();

            //FACADE
            //FacadeExample facade= new FacadeExample();


            //WithoutIterator
            //var waitress = new Waitress();
            //waitress.PrintMenu();

            //withiterator 
            //var newWaitress = new NewWaitressWithIterator(new DinerMenu(), new PancakeHouseMenu());
            //newWaitress.PrintMenu();


            //composite 
           // var compositePattern = new CompositePattern();

            //state pattern
            //var stateexample = new StateExample();

           // var stateExample = new StateExample(1);

            

            //strategy
            //var strategy = new StrategyExample(); 

            //proxy 
            var proxyExample = new ClientProxyPattern();
            Console.ReadKey();
        }
    }
}
