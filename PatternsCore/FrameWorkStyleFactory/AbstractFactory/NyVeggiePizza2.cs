namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class NyVeggiePizza2 : Pizza2
    {
        private IPizzaIngredientsFactory _ingredientsFactory;
        public NyVeggiePizza2(IPizzaIngredientsFactory ingredientsFactory)
        {
            _name = "Ny veggie pizza";
            _ingredientsFactory = ingredientsFactory;
            _dough = _ingredientsFactory.CreateDough();
            _souce = ingredientsFactory.CreateSauce();
            _toppings = ingredientsFactory.CreateVeggies();
        }
    }
}