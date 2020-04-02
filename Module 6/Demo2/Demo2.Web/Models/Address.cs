namespace Demo2.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        // Relationships
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}