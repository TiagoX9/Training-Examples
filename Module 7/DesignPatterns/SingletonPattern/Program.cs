using System;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
            Console.WriteLine(SingletonObject.Instance.GetMessage());
        }
    }
}
