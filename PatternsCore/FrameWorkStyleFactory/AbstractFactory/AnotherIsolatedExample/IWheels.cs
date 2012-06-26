namespace PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample
{
    public interface IWheels
        {
            int TireSize();
            string Move();
        }

    public class FerrariWheels : IWheels
        {
            public int TireSize()
                {   return 21;  }

            public string Move()
                {   return "Moving fast and not economically";  }
        }
    public class PriusWheels : IWheels
        {
            public int TireSize()
                {   return 15;  }

            public string Move()
                {   return "moving slowly and economically";}
        }
}