namespace PatternsCore.Composite
{
    public class CompositeWaitress
    {
        private readonly MenuComponent _allMenus;

        public CompositeWaitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}