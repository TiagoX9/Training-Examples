using System;
using System.ComponentModel.DataAnnotations;

namespace Demo4.Web.Models.EditModels
{
    public class TimeEntryEditModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLogged { get; set; }

        public int HoursWorked { get; set; }
        public int EmployeeId { get; set; }

        // Empty for the model binder
        public TimeEntryEditModel()
        {

        }

        public TimeEntryEditModel(int employeeId)
        {
            EmployeeId = employeeId;
            DateLogged = DateTime.Now;
        }
    }
}
