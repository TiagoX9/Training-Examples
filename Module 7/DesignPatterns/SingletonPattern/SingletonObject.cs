using System;

namespace SingletonPattern
{
    // Sealed - We don't allow inheritance
    public sealed class SingletonObject
    {
        // We load the instance through an static property
        private static SingletonObject instance = null;
        public static SingletonObject Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonObject();
                }
                return instance;
            }
        }

        private SingletonObject()
        {
            Console.WriteLine("Load new DB");
        }

        public string GetMessage()
        {
            return "Hello singleton";
        }
    }
}
