namespace PatternsCore.FrameWorkStyleFactory
{
    public class ChicagoVeggiePiza : Pizza
    {
        public ChicagoVeggiePiza()
        {
            _name = "Chicago style veggie pizza";
            _dough = "extra thick dough";
            _souce = "plum tomator";
            _toppings.Add("Shredded mozerella cheese");
            _toppings.Add("onions");
        }

        
    }
}