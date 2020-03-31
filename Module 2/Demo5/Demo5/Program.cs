using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo5
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
            // Always use TaskFactory instead of creating Tasks manually
            var tf = new TaskFactory();
            tf.StartNew(() => Write("Task 1"));
            tf.StartNew(() => Write("Task 2"));
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
