using System;
using PatternsCore.FrameWorkStyleFactory;
using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternAtWork.Factory
{
    public class FactoryPattern
    {
        public FactoryPattern()
        {
            for (;true;)
            {
                IPizzaStore store;
                Console.Out.Write("Please Select your store [1 for Ny 2 for Chicago]");
                string userInput = Console.In.ReadLine();

                if (userInput == "1")
                    store = new NyPizzaStore();
                else if (userInput == "2")
                    store = new ChicagoPizzaStore();
                else
                    break;
                
                if (store != null )
                {
                    Console.Out.Write("Please enter the pizza type[1 for veggie and 2 for pepperoni]");
                    userInput = Console.In.ReadLine();

                        if (userInput.Trim() == "1")
                        {
                            IPizza pizza = store.OrderPizza(PizzaType.Veggie);
                            Console.Out.WriteLine(pizza.Description() + "\n\n");
                        }
                        else if (userInput.Trim() == "2")
                        {
                            IPizza pizza = store.OrderPizza(PizzaType.Pepperoni);
                            Console.Out.WriteLine(pizza.Description() + "\n\n");
                        }
                }
            }
        }
    }
}