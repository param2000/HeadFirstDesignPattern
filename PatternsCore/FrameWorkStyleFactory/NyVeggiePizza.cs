namespace PatternsCore.FrameWorkStyleFactory
{
    public class NyVeggiePizza : Pizza
    {
        public NyVeggiePizza()
        {
            _name = "Ny veggie pizza";
            _dough = "extra thin dough";
            _souce = "marinara";
            _toppings.Add("regiana cheese");
            _toppings.Add("ny veggie toppings");
        }
    }
}