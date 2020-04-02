using System;

namespace Demo1.Web.Models
{
    public class Employee
    {
        // The property is automatically marked as key when named Id by convention
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
