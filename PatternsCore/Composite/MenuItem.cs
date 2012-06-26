using System;

namespace PatternsCore.Composite
{
    public class MenuItem:MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new UnSupportedOperationException();
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new UnSupportedOperationException();
        }

        public override MenuComponent GetChild(int i)
        {
            throw new UnSupportedOperationException();
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarion()
        {
            return _vegetarian;
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("{0}, Vege?={1}, Price={2}, Description= {3}",_name,_vegetarian,_price,_description));
        }
    }
}