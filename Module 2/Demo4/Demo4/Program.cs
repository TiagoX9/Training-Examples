using System;
using System.Threading;

namespace Demo4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DoSomething();
            Console.ReadKey();
        }

        private static void DoSomething()
        {
            // Always use ThreadPool instead of creating Threads manually
            ThreadPool.QueueUserWorkItem(Write, "Thread 1");
            ThreadPool.QueueUserWorkItem(Write, "Thread 2");
        }

        private static void Write(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}: {1}", data, i);
                Thread.Sleep(1000);
            }
        }
    }
}
