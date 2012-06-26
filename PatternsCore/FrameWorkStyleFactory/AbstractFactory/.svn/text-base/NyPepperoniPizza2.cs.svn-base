namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class NyPepperoniPizza2 : Pizza2
    {
        private IPizzaIngredientsFactory _ingredientsFactory;

        public NyPepperoniPizza2(IPizzaIngredientsFactory ingredientsFactory)
        {
            _name = "Ny pepperoni pizza ";
            _ingredientsFactory = ingredientsFactory;
            _dough = _ingredientsFactory.CreateDough();
            _souce = ingredientsFactory.CreateSauce();
            _toppings = ingredientsFactory.CreatePepperoni();
        }

    }
}