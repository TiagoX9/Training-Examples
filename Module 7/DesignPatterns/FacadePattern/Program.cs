namespace FacadePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var departmentFacade = new DepartmentFacade();
            departmentFacade.GetDepartments();
        }
    }
}
