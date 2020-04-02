namespace Demo2.Web.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public Person Person { get; set; }
    }
}