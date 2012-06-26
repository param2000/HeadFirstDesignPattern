using System.Collections;
using PatternsCore.Iterator;

namespace PatternsCore.WithoutIterator
{
    public class PancakeHouseMenu
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            AddItem("K&bool PancakeHouseMenu Breakfast", "Pancake with scrambled eggs", true, 2.99);
            AddItem("Regular Pancak Breakfast", "Pancake with fried eggs", false, 3.99);
            AddItem("Waffles", "with your choice of blueberries or strwberries", true, 4.99);
        }

        public void AddItem(string item, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(item, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }
        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }
    }
}