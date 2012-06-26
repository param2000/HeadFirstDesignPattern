namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    public interface IEngine
    {
        int Horsepower();
    }
    public class FerrariEngine:IEngine
    {
        public int Horsepower()
        {
            return 800;
        }
    }
    public class PriusEngine:IEngine
    {
        public int Horsepower()
        {
            return 150;
        }
    }
}