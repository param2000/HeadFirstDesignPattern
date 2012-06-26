using PatternsCore.SimpleFactory.Implementations;

namespace PatternsCore.SimpleFactory.Interfaces
{
    public interface IFactory
    {
        IPizza CreatePizza(PizzaType pizzaType);
    }
}

