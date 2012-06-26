namespace PatternsCore.Adapter
{
    /// <summary>
    /// Adapter always implements the interface of the type we are adapting to
    /// Adapter Accepts the object that we are adapting
    /// Adapter transforms the adapting objects methods to the methods of the objects we are adapting to
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _someTurkey;

        public TurkeyAdapter(ITurkey someTurkey)
        {
            _someTurkey = someTurkey;
        }

        public void Quack()
        {
            if (_someTurkey!=null)
                _someTurkey.Gobble();
        }

        public void Fly()
        {
            if (_someTurkey != null)
                for (int i = 0; i < 5; i++)
                    _someTurkey.Fly();
        }
    }
}