using System.Collections.Generic;

namespace Demo2.Web.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public Address Address { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
