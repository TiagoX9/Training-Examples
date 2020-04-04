namespace AdapterPattern.Models
{
    // Target
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual string Show()
        {
            return $"{Name} {Surname}";
        }
    }
}
