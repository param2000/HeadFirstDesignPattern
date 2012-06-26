using PatternsCore.FrameWorkStyleFactory.AbstractFactory;
using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory
{
    public class NyPizzaStore2 : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case  PizzaType.Veggie:
                    return new NyVeggiePizza2(new NyPizzaIngreadientsFactory());
                case PizzaType.Pepperoni:
                    return new NyPepperoniPizza2(new NyPizzaIngreadientsFactory());
                default:
                    return null;
            }
        }
    }
}