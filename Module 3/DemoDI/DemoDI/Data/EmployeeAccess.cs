using DemoDI.Interfaces;

namespace DemoDI.Data
{
    public class EmployeeAccess : IPersonAccess
    {
        public string GetPerson(int personId)
        {
            return $"Employee code {personId} | Doe, John";
        }
    }
}
