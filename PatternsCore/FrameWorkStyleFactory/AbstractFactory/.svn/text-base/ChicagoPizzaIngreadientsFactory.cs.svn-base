using System.Collections.Generic;

namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class ChicagoPizzaIngreadientsFactory:IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new ChicagoDough();
        }

        public ISauce CreateSauce()
        {
            return new TomatoSouce();
        }

        public ICheese CreateCheese()
        {
            return new MozerellaCheese();
        }

        public IList<ITopping> CreateVeggies()
        {
            IList<ITopping> list = new List<ITopping>();
            list.Add(new OnionVeggie());
            return list;
        }

        public IList<ITopping> CreatePepperoni()
        {
            IList<ITopping> list = new List<ITopping>();
            list.Add(new ChicagoPepperoni());
            return list;
        }
    }
}