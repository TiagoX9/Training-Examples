namespace Demo4.Web.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int TotalWorkedHours { get; private set; }
        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public EmployeeViewModel(int id, string name, string surname, int totalWorkedHours)
        {
            Id = id;
            Name = name;
            Surname = surname;
            TotalWorkedHours = totalWorkedHours;
        }
    }
}
