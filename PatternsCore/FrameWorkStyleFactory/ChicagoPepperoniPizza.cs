namespace PatternsCore.FrameWorkStyleFactory
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public ChicagoPepperoniPizza()
        {
            _name = "Chicago style pepperoni pizza";
            _dough = "extra thick dough";
            _souce = "plum tomator";
            _toppings.Add("Shredded mozerella cheese");
            _toppings.Add("chicago pepperoni toppings");
        }
    }
}
