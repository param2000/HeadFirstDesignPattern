using PatternsCore.FrameWorkStyleFactory.AbstractFactory;

namespace PatternsCore.FrameWorkStyleFactory
{
    public class NyPepperoniPizza : Pizza
    {
        public NyPepperoniPizza()
        {
            _name = "Ny pepperoni pizza";
            _dough = "extra thin dough";
            _souce = "marinara";
            _toppings.Add("regiana cheese");
            _toppings.Add("ny pepperoni toppings");
    
        }

    }
}