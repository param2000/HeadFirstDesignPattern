using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.SimpleFactory.Implementations
{
    public class SimplePizzaFactory: IFactory
    {
        public IPizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Greeek:
                    return new GreeekPizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                case PizzaType.Veggie:
                    return new VeggiePizza();
                default:
                    return null;
            }
        }
    }
}