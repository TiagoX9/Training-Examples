using FacadePattern.Models;

namespace FacadePattern
{
    public class DepartmentFacade
    {
        private readonly HumanResources _humanResources;
        private readonly Finance _finance;

        public DepartmentFacade()
        {
            _humanResources = new HumanResources();
            _finance = new Finance();
        }

        public void GetDepartments()
        {
            _humanResources.GetHr();
            _finance.GetFinance();
        }
    }
}
