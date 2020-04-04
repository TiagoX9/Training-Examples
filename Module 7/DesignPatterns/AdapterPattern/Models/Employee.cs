namespace AdapterPattern.Models
{
    // Adapter class
    public class Employee : Person
    {
        private readonly int _workingDays;

        public Employee(string name, string surname, int workingDays) : base(name, surname)
        {
            _workingDays = workingDays;
        }

        public override string Show()
        {
            var calculateSalary = new SalaryInformation(_workingDays);

            return $"{ base.Show() } | { calculateSalary.CalculateSalary() } CZK";
        }
    }
}
