using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory
{
    public class NyPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case  PizzaType.Veggie:
                    return new NyVeggiePizza();
                case PizzaType.Pepperoni:
                    return new NyPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}