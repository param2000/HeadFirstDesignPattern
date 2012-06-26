namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    public interface ICar
        {
            string GetCar();
            string Name();
        }

    public abstract class Car:ICar
        {
            private IWheels _wheels;
            private IBody _body;
            private IEngine _engine;
        
            protected Car(ICarPartsBuilder builder)
                {
                    this._wheels = builder.CreateWheel();
                    this._body = builder.CreateBody();
                    this._engine = builder.CreateEngine();
                }

            public string GetCar()
                {
                    return Name()
                           + "\nWheels Size: " + _wheels.TireSize()
                           + "\nWheels Move: " + _wheels.Move()
                           + "\nBody Material: " + _body.Material() 
                           + "\nBody Weight: " + _body.Weight() 
                           + "\nEngine Horsepower: " + _engine.Horsepower();
                }

            public abstract string Name();
        }
}