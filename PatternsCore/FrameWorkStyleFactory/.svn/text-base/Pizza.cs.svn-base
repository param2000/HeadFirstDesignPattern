using System.Collections.Generic;
using System.Linq;
using PatternsCore.SimpleFactory.Interfaces;

namespace PatternsCore.FrameWorkStyleFactory
{
    public abstract class Pizza:IPizza
    {
        protected string _name;
        protected string _dough;
        protected string _souce;
        protected IList<string> _toppings;

        protected Pizza()
        {
            _toppings= new List<string>();
        }

        public void Prepare()
        {
            System.Console.Out.WriteLine("Preparing {0}",_name);
            System.Console.Out.WriteLine("tossing {0}",_dough);
            System.Console.Out.WriteLine("adding {0} souce",_souce);
            System.Console.Out.WriteLine("adding {0} toppings",Topping());
        }

        protected string Topping()
        {
            return _toppings.Aggregate<string, string>(null, (current, topping) => current + (topping + ","));
        }
    
        public void Bake()
        {
            System.Console.Out.WriteLine("Baking for 25 minutes");
        }

        public void Cut()
        {
            System.Console.Out.WriteLine("Cutting the pizza into diagnol slices");
        }

        public void Box()
        {
            System.Console.Out.WriteLine("Place pizza in the box");
        }

        public string Description()
        {
            return _name;
        }
    }
}