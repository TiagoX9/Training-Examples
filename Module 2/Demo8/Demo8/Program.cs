using System;

namespace Demo8
{
    // Create the class Person before doing any of this
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person("Streetova 10");
            person.Name = "John";
            person.Surname = "Doe";

            Console.WriteLine(person.ToString());
        }
    }
}
