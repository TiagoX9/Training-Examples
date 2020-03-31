using System;

// Namespace is used to organize the classes
namespace Demo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.Write() - Writes and stays in the same line
            // Console.WriteLine() - Writes and goes to the next line
            // Console.Read() - Reads and stays in the same line
            // Console.ReadLine() - Reads and goes to the next line
            // Console.ReadKey() - Reads any key

            Console.Write("Enter the first number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondNumber = Console.ReadLine();

            //// We need to parse since the values come as string
            int result = int.Parse(firstNumber) + int.Parse(secondNumber);

            //// Uncomment to show method example
            // int result = Calculation(int.Parse(firstNumber), int.Parse(secondNumber));

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
            Console.ReadKey();
        }

        public static int Calculation(int firstNumber, int secondNumber)
        {
            // Values here come parsed, easy to calculate
            return firstNumber + secondNumber;
        }
    }
}
