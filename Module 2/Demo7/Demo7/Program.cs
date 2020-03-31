using System;
using System.Collections.Generic;

namespace Demo7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Type a number: ");

            //// 1. EXCEPTION HANDLING
            // No handling
            int value = int.Parse(Console.ReadLine());

            //// Some handling
            //if (int.TryParse(Console.ReadLine(), out int value))
            //{
            //    Console.WriteLine("value ok: {0}", value);
            //}
            //else
            //{
            //    // It will crash the program and should be handled somewhere else
            //    throw new ArgumentException("Wrong value, noob: {0}", nameof(value));
            //}

            //// With exception handling
            //int value = 0;
            //try
            //{
            //    value = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException fEx) // catches specific exception
            //{
            //    Console.WriteLine(fEx.Message);
            //}
            //catch (Exception ex)
            //{
            //    // First option - doesn't crash the app
            //    //Console.WriteLine("Invalid value");

            //    // Second option - doesn't crash the app and shows the real message
            //    //Console.WriteLine("ERROR: {0}", ex.Message);

            //    // Third option - propagates the error, someone else should take care of it
            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("FINALLY!");
            //}

            //// 2. IF-ELSE
            if (value > 10)
            {
                Console.WriteLine("value > 10");
            }
            else
            {
                Console.WriteLine("value < 10");
            }

            //// 3. SWITCH
            switch (value)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("More than three");
                    break;
            }

            //// 4. FOR
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("value: {0}", i);
            }

            //// 5. FOREACH
            var listNumbers = new List<int> { 10, 20, 30, 40, 50 };
            foreach (var item in listNumbers)
            {
                if (item == 30)
                {
                    //// Break stops the execution
                    break;

                    //// Continue skips the execution (one step)
                    //continue;
                }

                Console.WriteLine("value: {0}", item);
            }

            //// 6. WHILE
            while (value > 0)
            {
                Console.WriteLine("value: {0}", value);
                value--;
            }

            //// 7. DO
            do
            {
                Console.WriteLine("value: {0}", value);
                value--;
            } while (value > 0);

            Console.ReadKey();
        }
    }
}
