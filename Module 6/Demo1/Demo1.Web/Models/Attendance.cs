using System;

namespace Demo1.Web.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateAttendance { get; set; }
    }
}
