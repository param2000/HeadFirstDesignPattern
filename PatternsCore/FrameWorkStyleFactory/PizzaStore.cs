using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory
{
    public abstract class PizzaStore:IPizzaStore
    {

        public IPizza OrderPizza(PizzaType pizzaType)
        {
            IPizza pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        /// <summary>
        /// Abstract Factory Method
        /// 
        /// </summary>
        public abstract IPizza CreatePizza(PizzaType pizzaType);

    }
}