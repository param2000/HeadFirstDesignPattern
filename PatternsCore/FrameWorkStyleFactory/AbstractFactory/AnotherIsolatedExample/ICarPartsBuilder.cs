namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    /// <summary> Abstract Factory Implementation 
    /// Could be abstract class or interface
    /// </summary>
    public interface ICarPartsBuilder
    {
        IWheels CreateWheel();
        IBody CreateBody();
        IEngine CreateEngine();
    }

    
    
    
    
    
    
    public class FerrariBuilder:ICarPartsBuilder
    {
        public IWheels CreateWheel()
        {   return new FerrariWheels(); }

        public IBody CreateBody()
        {   return new FerrariBody();   }

        public IEngine CreateEngine()
        {   return new FerrariEngine(); }
    }

    public class PriusBuilder : ICarPartsBuilder
    {
        public IWheels CreateWheel()
        {   return new PriusWheels();   }

        public IBody CreateBody()
        {   return new PriusBody(); }

        public IEngine CreateEngine()
        {   return new PriusEngine();   }
    }
}