using System;

namespace PatternsCore.Adapter
{
    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        { Console.WriteLine("I am Gobble Gobble "); }

        public void Fly()
        { Console.WriteLine("I am Flying Short Distance "); }
    }
}