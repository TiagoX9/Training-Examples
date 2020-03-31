namespace DemoDI.Data
{
    //// WITHOUT DI
    public class PersonAccess

    //// WITH DI
    //public class PersonAccess : IPersonAccess
    {
        public string GetPerson(int personId)
        {
            return $"Id: {personId} | Name: John Doe";
        }
    }
}
