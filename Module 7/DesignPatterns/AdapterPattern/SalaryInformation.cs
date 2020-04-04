namespace AdapterPattern
{
    // Adaptee, bringing extra logic
    public class SalaryInformation
    {
        private readonly int _workingDays;

        public SalaryInformation(int workingDays)
        {
            _workingDays = workingDays;
        }

        public int CalculateSalary()
        {
            return 500 * _workingDays;
        }
    }
}
