namespace PatternsCore.Facade
{
    public class HomeTheaterFacade : IMovieFunctions
    {
        private readonly AmplifierAmp _amp;
        private readonly DvdPlayer _player;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly TheaterLights _lights;

        public HomeTheaterFacade(AmplifierAmp amp, DvdPlayer player, Projector projector, Screen screen, TheaterLights lights)
        {
            _amp = amp;
            _player = player;
            _projector = projector;
            _screen = screen;
            _lights = lights;
        }


        public void WatchMovie(string movie)
        {
            _lights.Dim(10);
            _screen.On();
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _player.On();
            _player.PlayMovie(movie);
        }

        public void EndMovie()
        {
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _player.Stop();
            _player.Eject();
            _player.Off();
        }
    }
}