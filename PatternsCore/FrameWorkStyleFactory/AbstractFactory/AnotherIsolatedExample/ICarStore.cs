namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    public interface ICarStore
        {   Car BuildMyCar(ICarPartsBuilder  carPartsBuilder);  }














    public class FerrariStore:ICarStore
        {   public Car BuildMyCar(ICarPartsBuilder carPartsBuilder)
                {   return  new FerrariCar(new FerrariBuilder());   }
        }

    public class PriusStore:ICarStore
        {   public Car BuildMyCar(ICarPartsBuilder carPartsBuilder)
                {   return new PriusCar(new PriusBuilder());    }
        }
}