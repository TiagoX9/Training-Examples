using System;
using System.Collections.Generic;

namespace Demo3.Web.Models
{
    public partial class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
