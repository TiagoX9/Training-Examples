namespace Demo3.Api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public Person(int id, string name, string surname, string age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
