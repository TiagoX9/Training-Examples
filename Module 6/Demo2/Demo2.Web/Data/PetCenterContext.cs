using Demo2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo2.Web.Data
{
    public class PetCenterContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Pet> Pet { get; set; }

        public PetCenterContext(DbContextOptions<PetCenterContext> options) : base(options)
        {

        }
    }
}
