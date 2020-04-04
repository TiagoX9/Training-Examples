using FactoryPattern.Departments;

namespace FactoryPattern.Factories
{
    public abstract class DepartmentFactory
    {
        public abstract Department GetDepartment();
    }
}
