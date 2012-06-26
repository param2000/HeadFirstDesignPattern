using System;

namespace PatternsCore.Facade
{
    public class DvdPlayer
    {
        private string _movie;
        public void On()
        {
            Console.WriteLine("DVD is on ");
        }

        public void PlayMovie(string movie)
        {
            _movie = movie;
            Console.WriteLine(string.Format("DVD is playing {0} movie", _movie));
        }

        public void Stop()
        {
            Console.WriteLine("DVD is stopped");
        }

        public void Eject()
        {
            
            
            Console.WriteLine(String.Format("Ejecting movie {0} ...  ",_movie));
        }

        public void Off()
        {
            Console.WriteLine("DVD is Off ");
        }
    }
}