using System.Collections.Generic;

namespace Demo4.Web.Models.EditModels
{
    public class EmployeeEditModel
    {
        public bool IsNew
        {
            get
            {
                return Id == 0;
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public IEnumerable<int> TimeEntryIds { get; set; }

        // For the model binder
        public EmployeeEditModel()
        {

        }

        public EmployeeEditModel(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
