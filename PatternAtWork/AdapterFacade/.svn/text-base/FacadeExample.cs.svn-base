using System;
using PatternsCore.Facade;

namespace PatternAtWork.AdapterFacade
{
    public class FacadeExample
    {
        public FacadeExample()
        {
            IMovieFunctions theatureFacade= new HomeTheaterFacade(new AmplifierAmp(), new DvdPlayer(), new Projector(), new Screen(), new TheaterLights());

            theatureFacade.WatchMovie("Matrix");

            Console.WriteLine("Movie Finished...............\n\n\n\n\n\n");

            theatureFacade.EndMovie();
             

            Console.ReadLine();
        }
    }
}