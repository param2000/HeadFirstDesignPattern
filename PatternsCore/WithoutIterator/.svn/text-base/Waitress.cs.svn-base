using System;
using System.Collections;
using PatternsCore.Iterator;

namespace PatternsCore.WithoutIterator
{
    public class Waitress
    {
        private readonly DinerMenu _dinerMenu;
        private readonly PancakeHouseMenu _pancakeHouseMenu;

        public Waitress()
        {
            _dinerMenu= new DinerMenu();
            _pancakeHouseMenu=new PancakeHouseMenu();
        }

        public void PrintMenu()
        {
            ArrayList breakfast = _pancakeHouseMenu.GetMenuItems();
            for (int i = 0; i < breakfast.Count; i++)
                Console.WriteLine(String.Format("Name={0} Description={1} Vege?={2} Price={3}", ((MenuItem)breakfast[i]).Name, ((MenuItem)breakfast[i]).Description, ((MenuItem)breakfast[i]).Vegetarian, ((MenuItem)breakfast[i]).Price));
            
            Console.WriteLine("===============================================================================");
            
            MenuItem[] diner = _dinerMenu.GetMenuItems();
            for (int i = 0; i < diner.Length; i++)
                Console.WriteLine(String.Format("Name={0} Description={1} Vege?={2} Price={3}", diner[i].Name, diner[i].Description, diner[i].Vegetarian, diner[i].Price));
            
            Console.WriteLine("===============================================================================");
        }
    }
}