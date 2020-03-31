using Demo2.Utils;
using System;

namespace Demo2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine();

            int result = MathLib.Calculation(int.Parse(firstNumber), int.Parse(secondNumber));

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
            Console.ReadKey();
        }
    }
}
