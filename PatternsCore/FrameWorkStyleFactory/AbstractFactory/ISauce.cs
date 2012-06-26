namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public interface ISauce
    {
        string ToString();
    }
    public class MarinaraSouce:ISauce
    {
        public override string ToString()
        {
            return "marinara sauce";
        }
    }

    public class TomatoSouce:ISauce
    {
        public override string ToString()
        {
            return "plum tomator sauce";
        }
    }
}