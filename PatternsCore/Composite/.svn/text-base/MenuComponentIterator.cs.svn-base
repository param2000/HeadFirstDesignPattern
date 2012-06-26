using System.Collections;
using PatternsCore.Iterator;

namespace PatternsCore.Composite
{
    public class MenuComponentIterator : IIterator
    {
        private readonly ArrayList _items;
        private int _position;
        public MenuComponentIterator(ArrayList items)
        {
            _items = items;
            _position = 0;
        }

        public bool HasNext()
        {
            return (_position < _items.Count );
        }

        public object Next()
        {
            var item = _items[_position];
            _position++;
            return item;
        }
    }
}