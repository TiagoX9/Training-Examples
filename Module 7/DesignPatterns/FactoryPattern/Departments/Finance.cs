namespace FactoryPattern.Departments
{
    public class Finance : Department
    {
        public override string GetMessage()
        {
            return "Hello from finance";
        }
    }
}
