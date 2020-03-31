using System;
using System.Threading.Tasks;

namespace Demo6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // GetAwaiter() unwraps the exceptions
            // GetResult() forces the method to run synchronously
            DoSomething().GetAwaiter().GetResult();
            Console.ReadKey();
        }

        private static async Task DoSomething()
        {
            await Write("Async 1");
            await Write("Async 2");
        }

        private static async Task Write(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}: {1}", data, i);
            }
        }
    }
}
