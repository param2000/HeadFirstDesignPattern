using PatternsCore.SimpleFactory.Implementations;

namespace PatternsCore.SimpleFactory.Interfaces
{
    public  interface IPizzaStore
    {
        IPizza OrderPizza(PizzaType pizzaType);
    }
}