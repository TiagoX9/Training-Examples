using DemoDI.Data;

namespace DemoDI
{
    //// WITHOUT DI

    //public class PersonBusinessLogic
    //{
    //    private readonly PersonAccess _personAccess;

    //    public PersonBusinessLogic()
    //    {
    //        _personAccess = new PersonAccess();
    //    }

    //    public string GetPerson(int personId)
    //    {
    //        return _personAccess.GetPerson(personId);
    //    }
    //}



    //// WITH DI

    public class PersonBusinessLogic
    {
        private readonly IPersonAccess _personAccess;

        public PersonBusinessLogic(IPersonAccess personAccess)
        {
            _personAccess = personAccess;
        }

        public string GetPerson(int personId)
        {
            return _personAccess.GetPerson(personId);
        }
    }
}
