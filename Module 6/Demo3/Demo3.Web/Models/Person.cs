using System;
using System.Collections.Generic;

namespace Demo3.Web.Models
{
    public partial class Person
    {
        public Person()
        {
            Pet = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Pet> Pet { get; set; }
    }
}
