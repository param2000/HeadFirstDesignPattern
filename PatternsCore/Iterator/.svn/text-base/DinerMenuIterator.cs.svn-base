namespace PatternsCore.Iterator
{
    public class DinerMenuIterator: IIterator
    {
        private readonly MenuItem[] _items;
        private int _position;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
            _position = 0;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem item = _items[_position];
            _position++;
            return item;
        }
    }
}