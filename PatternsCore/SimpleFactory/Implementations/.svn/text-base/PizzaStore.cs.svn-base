using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.SimpleFactory.Implementations
{
    public class PizzaStore :IPizzaStore
    {
        private readonly SimplePizzaFactory _pizzaSimplePizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaSimplePizzaFactory)
        {
            this._pizzaSimplePizzaFactory = pizzaSimplePizzaFactory;
        }

        public IPizza OrderPizza(PizzaType pizzaType)
        {
            IPizza pizza = _pizzaSimplePizzaFactory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}