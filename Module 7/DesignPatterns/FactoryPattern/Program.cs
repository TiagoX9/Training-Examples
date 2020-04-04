using FactoryPattern.Factories;
using System;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Choose a department [fi / hr]:");
            string choice = Console.ReadLine();

            DepartmentFactory factory = null;

            switch (choice)
            {
                case "fi":
                    factory = new FinanceFactory();
                    break;
                case "hr":
                    factory = new HumanResourcesFactory();
                    break;
                default:
                    Console.WriteLine("No factory");
                    Environment.Exit(0);
                    break;
            }

            var department = factory.GetDepartment();
            Console.WriteLine(department.GetMessage());
        }
    }
}
