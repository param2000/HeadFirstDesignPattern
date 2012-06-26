namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class ChicagoVeggiePiza : Pizza2
    {
        private IPizzaIngredientsFactory _ingredientsFactory;
        public ChicagoVeggiePiza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _name = "Chicago style veggie pizza";
            _ingredientsFactory = ingredientsFactory;
            _dough = _ingredientsFactory.CreateDough();
            _souce = ingredientsFactory.CreateSauce();
            _toppings = ingredientsFactory.CreateVeggies();
        }
    }
}