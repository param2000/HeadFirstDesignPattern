using System;

namespace PatternsCore.Facade
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on ");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector is in wider screen mode now");
        }

        public void Off()
        {
            Console.WriteLine("Projector is Off ");
        }
    }
}