using System.Collections;

namespace PatternsCore.Iterator
{
    public class BreakfastMenuIterator: IIterator
    {
        private ArrayList _items;
        private int _position;
        public BreakfastMenuIterator(ArrayList items)
        {
            _items = items;
            _position = 0;
        }

        public bool HasNext()
        {
            if (_position >= _items.Count || _items[_position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem item = (MenuItem)_items[_position];
            _position++;
            return item;
        }
    }
}