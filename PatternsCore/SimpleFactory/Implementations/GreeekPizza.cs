using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.SimpleFactory.Implementations
{
    public class GreeekPizza : IPizza
    {
        
        private string _desc ;

        public GreeekPizza()
        {
            _desc = "Greeek pizza ";
        }

        public void Prepare()
        {
            _desc += " prepared ";
        }

        public void Bake()
        {
            _desc += " baked ";
        }

        public void Cut()
        {
            _desc += " cut ";
        }

        public void Box()
        {
            _desc += " boxed ";
        }

        public string Description()
        {
            return _desc;
        }
    }
}