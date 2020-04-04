using AdapterPattern.Models;
using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Non-adapted
            Person johnDoe = new Person("John", "Doe");
            Console.WriteLine(johnDoe.Show());

            // Adapted
            Person marySue = new Employee("Mary", "Sue", 20);
            Console.WriteLine(marySue.Show());
        }
    }
}
