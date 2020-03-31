namespace Demo8
{
    public class Person
    {
        // 1. Read-only members (value set on execution time)
        private readonly string _address;

        // 2. Constant members (value set on compile time)
        private const string COUNTRY = "CZ";

        // 3. Properties (show also propfull and explain that properties are methods in disguise)
        public string Name { get; set; }
        public string Surname { get; set; }

        // 4. Constructor
        public Person(string address)
        {
            _address = address;
        }

        // 5. Overloading methods
        public override string ToString()
        {
            return $"{Name} {Surname} | {_address}, {COUNTRY}";
        }
    }
}
