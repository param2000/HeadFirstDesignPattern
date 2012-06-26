namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    public class PriusCar : Car
    {
        public PriusCar(ICarPartsBuilder builder): base(builder)
            {}

        public override string Name()
            {   return "Prius Car";     }
    }
}