using System;

namespace Demo3
{
    internal class Program
    {
        // The idea is to try to change the values from the outside of the method
        private static void Main(string[] args)
        {
            // Value type
            var personVal = new PersonValue
            {
                Name = "Diana",
                Age = 35
            };
            Console.WriteLine("personVal: {0}", personVal.ToString());
            ChangePersonValue(personVal);
            Console.WriteLine("personVal: {0}", personVal.ToString());

            // Reference type
            var personRef = new PersonReference
            {
                Name = "John",
                Age = 40
            };
            Console.WriteLine("personRef: {0}", personRef.ToString());
            ChangePersonReference(personRef);
            Console.WriteLine("personRef: {0}", personRef.ToString());
        }

        // Tries to change the value of the properties
        // It changes the value but doesn't return anything
        // Nothing happens, no new values
        private static void ChangePersonValue(PersonValue personValue)
        {
            personValue.Name = "Martha";
            personValue.Age = 50;
        }

        // Tries to change the value of the properties
        // It changes the value and update references
        // The object from the caller shows new values
        private static void ChangePersonReference(PersonReference personReference)
        {
            personReference.Name = "Bob";
            personReference.Age = 25;
        }
    }
}
