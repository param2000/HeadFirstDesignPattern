namespace PatternsCore.Singleton
{
    //INCORRECT IMPLEMENTATION
    public class SingletonDatabaseConnection
    {
        private static SingletonDatabaseConnection _uniqueInstance;
        private SingletonDatabaseConnection()
            {}

        /// <summary>
        /// Possibly same threads at if block can generate to objects[incomplete not correct implementation]
        /// </summary>
        public static SingletonDatabaseConnection GetInstance()
        {
            //lazy loading
            if(_uniqueInstance==null)
                _uniqueInstance= new SingletonDatabaseConnection();

            return _uniqueInstance;
        }
    }

    
}