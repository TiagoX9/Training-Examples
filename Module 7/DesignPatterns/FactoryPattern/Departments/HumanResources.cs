namespace FactoryPattern.Departments
{
    public class HumanResources : Department
    {
        public override string GetMessage()
        {
            return "Hey, here is your HR";
        }
    }
}
