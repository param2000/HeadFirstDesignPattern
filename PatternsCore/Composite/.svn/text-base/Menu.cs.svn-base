using System;
using System.Collections;
using PatternsCore.Iterator;

namespace PatternsCore.Composite
{
    public class Menu : MenuComponent
    {
        private readonly ArrayList _menuComponents;
        private readonly string _name;
        private readonly string _desc;

        public Menu(string name, string desc)
        {
            _name = name;
            _desc = desc;
            _menuComponents = new ArrayList();
        }

        public override void Add(MenuComponent menuComponent)
        { _menuComponents.Add(menuComponent); }

        public override void Remove(MenuComponent menuComponent)
        { _menuComponents.Remove(menuComponent); }

        public override MenuComponent GetChild(int i)
        { return (MenuComponent)_menuComponents[i]; }

        public override string GetName()
        { return _name; }

        public override string GetDescription()
        { return _desc; }


        public override void Print()
        {
            Console.WriteLine("\n{0}, {1}", _name, _desc);
            Console.WriteLine("---------------------------------------");
            IIterator iterator = new MenuComponentIterator(_menuComponents);
            while (iterator.HasNext())
            {
                var item = (MenuComponent)iterator.Next();
                //Console.WriteLine("     ");
                item.Print();
            }
        }

        public override double GetPrice()
        { throw new UnSupportedOperationException(); }

        public override bool IsVegetarion()
        { throw new UnSupportedOperationException(); }
    }
}