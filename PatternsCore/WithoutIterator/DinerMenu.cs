using System;
using PatternsCore.Iterator;

namespace PatternsCore.WithoutIterator
{
    public class DinerMenu
    {
        const int MaxItem = 3;
        private int _numOfItemPresent;
        private readonly MenuItem[] _menuItems;
        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItem];
            _numOfItemPresent = 0;

            AddItem("Vege BLT", "Bacon with Lettuce", false, 2.99);
            AddItem("BLT", "Bacon with Lettuce and Tomato", false, 3.99);
            AddItem("Hotdog", "Hotdog with relish and onions", false, 4.99);
        }

        public void AddItem(string item, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(item, description, vegetarian, price);
            if (_numOfItemPresent >= MaxItem)
                Console.WriteLine("Error menu is full!");
            else
            {
                _menuItems[_numOfItemPresent] = menuItem;
                _numOfItemPresent++;
            }
        }
        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }
    }
}