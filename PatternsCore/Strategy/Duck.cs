namespace PatternsCore.Strategy
{
    public class Duck
    {
        private IFly _flyobj;

        public Duck(IFly obj)
            {_flyobj = obj;}

        public  void Fly()
            {_flyobj.Fly();}

        public IFly Flyobj
        {
            get { return _flyobj; }
            set { _flyobj = value; }
        }
    }
}
