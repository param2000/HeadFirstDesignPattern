using System.Runtime.CompilerServices;

namespace PatternsCore.Singleton
{
    //CORRECT IMPLEMENTATION
    public class SingletonDatabaseConnection2
    {
        private static SingletonDatabaseConnection2 _uniqueInstance;

        private SingletonDatabaseConnection2()
        {}
        /// <summary>
        /// SYNCHRONISED CAN ADD ALOT OF OVERHEAD
        /// [statement needs research in c#, true in java]
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonDatabaseConnection2 GetInstance()
        {
            //LAZY LOADING
            if (_uniqueInstance == null)
                _uniqueInstance = new SingletonDatabaseConnection2();

            return _uniqueInstance;
        }

    }
}