using System;

namespace Demo4.Web.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public DateTime DateLogged { get; set; }
        public int HoursWorked { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
