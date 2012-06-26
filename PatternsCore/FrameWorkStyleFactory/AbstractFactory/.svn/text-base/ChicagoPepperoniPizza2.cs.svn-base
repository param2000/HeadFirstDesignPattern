
namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class ChicagoPepperoniPizza2 : Pizza2
    {
        private IPizzaIngredientsFactory _ingredientsFactory;
        public ChicagoPepperoniPizza2(IPizzaIngredientsFactory ingredientsFactory)
        {
            _name = "Chicago style pepperoni pizza";
            _ingredientsFactory = ingredientsFactory;
            _dough = _ingredientsFactory.CreateDough();
            _souce = ingredientsFactory.CreateSauce();
            _toppings = ingredientsFactory.CreatePepperoni();
        }
    }
}
