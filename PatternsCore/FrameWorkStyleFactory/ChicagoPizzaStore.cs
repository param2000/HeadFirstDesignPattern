using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory
{
    public  class ChicagoPizzaStore:PizzaStore 
    {
        public override IPizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:
                    return new ChicagoVeggiePiza();
                case PizzaType.Pepperoni:
                    return new ChicagoPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}