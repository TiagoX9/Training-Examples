using FactoryPattern.Departments;

namespace FactoryPattern.Factories
{
    public class HumanResourcesFactory : DepartmentFactory
    {
        public override Department GetDepartment()
        {
            return new HumanResources();
        }
    }
}
