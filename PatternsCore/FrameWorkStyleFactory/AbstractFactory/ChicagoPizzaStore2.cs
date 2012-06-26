using PatternsCore.SimpleFactory.Implementations;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public  class ChicagoPizzaStore2:PizzaStore 
    {

        public override IPizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:
                    return new ChicagoVeggiePiza(new ChicagoPizzaIngreadientsFactory());
                case PizzaType.Pepperoni:
                    return new ChicagoPepperoniPizza2(new ChicagoPizzaIngreadientsFactory());
                default:
                    return null;
            }
        }
    }
}