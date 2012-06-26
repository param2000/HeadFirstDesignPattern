namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory
{
    public interface ICheese
    {
        string ToString();
    }
    public class ReginaCheese:ICheese
    {
        public override string ToString()
        {
            return "regiana cheese";
        }
    }
    public class MozerellaCheese : ICheese
    {
        public override string ToString()
        {
            return "mozerella cheese";
        }
    }
}