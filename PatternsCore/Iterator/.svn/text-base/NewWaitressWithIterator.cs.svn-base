using System;

namespace PatternsCore.Iterator
{
    public class NewWaitressWithIterator
    {
        private readonly DinerMenuIterator _dinerIterator;
        private readonly BreakfastMenuIterator   _breakfastMenuIterator;

        public NewWaitressWithIterator(DinerMenu dinerMenu, PancakeHouseMenu pancakeHouseMenu)
        {
            _dinerIterator = dinerMenu.CreateIterator();
            _breakfastMenuIterator = pancakeHouseMenu.CreateIterator();
        }

        public void PrintMenu()
        {
            Console.WriteLine("=============================Lunch==========================");            
            IteratorPrinter(_dinerIterator);
            Console.WriteLine("\n" +
                              "=============================BreakFast======================");
            IteratorPrinter(_breakfastMenuIterator);
        }
        private void IteratorPrinter(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem) iterator.Next();
                Console.WriteLine(String.Format("Name={0} Description={1} Vege?={2} Price={3}", menuItem.Name, menuItem.Description, menuItem.Vegetarian, menuItem.Price));
            }
        }
    }
}