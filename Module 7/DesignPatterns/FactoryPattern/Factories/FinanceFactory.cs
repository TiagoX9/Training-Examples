using FactoryPattern.Departments;

namespace FactoryPattern.Factories
{
    public class FinanceFactory : DepartmentFactory
    {
        public override Department GetDepartment()
        {
            return new Finance();
        }
    }
}
