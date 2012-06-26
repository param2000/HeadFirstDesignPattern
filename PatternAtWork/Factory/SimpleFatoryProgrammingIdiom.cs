using System;
using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternAtWork.Factory
{
    public class SimpleFatoryProgrammingIdiom
    {
        public SimpleFatoryProgrammingIdiom()
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());

            for (; true;)
            {
                IPizza pizza;
                Console.Out.Write("Enter your Selection\n[1 for Veggie, 2 for Greek, 3 for Pepperoni]");
                string userInput = Console.In.ReadLine();
                
                if (userInput.Trim() == "1")
                {
                    pizza = pizzaStore.OrderPizza(PizzaType.Veggie);
                    Console.Out.WriteLine(pizza.Description() + "\n\n");
                }
                else if (userInput.Trim() == "2")
                {
                    pizza = pizzaStore.OrderPizza(PizzaType.Greeek);
                    Console.Out.WriteLine(pizza.Description() + "\n\n");
                }
                else if (userInput.Trim() == "3")
                {
                    pizza = pizzaStore.OrderPizza(PizzaType.Pepperoni);
                    Console.Out.WriteLine(pizza.Description() + "\n\n");
                }
                else
                    break;
            }
        }
    }

}