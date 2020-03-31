using System;

namespace DemoDI
{
    internal class Program
    {
        //// WITHOUT DI
        //// 1. Create PersonBusinessLogic
        //// 2. Create PersonAccess
        //// 2. Create Main method

        //private static void Main(string[] args)
        //{
        //    Console.Write("Enter an ID number: ");
        //    int id = Convert.ToInt32(Console.ReadLine());

        //    var personBusinessLogic = new PersonBusinessLogic();
        //    string result = personBusinessLogic.GetPerson(id);

        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}



        //// WITH DI
        //// 1. Create an IPersonAccess interface
        //// 2. Create PersonAccess implementation
        //// 3. Edit PersonBusinessLogic
        //// 4. Edit instantiation of PersonBusinessLogic on Main method
        //// 5. Make a call to EmployeeAccess

        private static void Main(string[] args)
        {
            Console.Write("Enter an ID number: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var personBusinessLogic = new PersonBusinessLogic(new PersonAccess());

            // Call Employee access later
            //var personBusinessLogic = new PersonBusinessLogic(new EmployeeAccess());

            string result = personBusinessLogic.GetPerson(id);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
