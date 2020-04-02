using System;
using System.Collections.Generic;

namespace Demo3.Web.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
