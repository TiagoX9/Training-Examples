using System.Collections.Generic;

namespace Demo4.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
    }
}
