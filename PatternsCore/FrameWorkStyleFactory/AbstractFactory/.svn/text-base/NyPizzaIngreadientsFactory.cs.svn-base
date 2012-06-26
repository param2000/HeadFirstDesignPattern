using System.Collections.Generic;

namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public class NyPizzaIngreadientsFactory:IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new NyDough();
        }

        public ISauce CreateSauce()
        {
         return new MarinaraSouce();
        }

        public ICheese CreateCheese()
        {
            return new ReginaCheese();
        }

        public IList<ITopping> CreateVeggies()
        {
            IList<ITopping> list = new List<ITopping>();
            list.Add(new GreeenPeppersVeggie());
            return list;
        }

        public IList<ITopping> CreatePepperoni()
        {

            IList<ITopping> list = new List<ITopping>();
            list.Add(new NyPepperoni());
            return list;
        }
    }
}