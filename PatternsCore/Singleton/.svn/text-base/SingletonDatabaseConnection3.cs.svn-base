namespace PatternsCore.Singleton
{
    /// <summary>
    /// CORRECT IMPLEMENTATION
    /// </summary>
    public class SingletonDatabaseConnection3
    {
        private static SingletonDatabaseConnection3 _uniqueInstance= new SingletonDatabaseConnection3();

        private SingletonDatabaseConnection3()
        {}
        /// <summary>
        /// EAGERLY LOAD 
        /// [Needs research in c# that just by using static will solve synchonised problem ]
        /// </summary>
        
        public static SingletonDatabaseConnection3 GetInstance()
        {   return _uniqueInstance; }

    }
}