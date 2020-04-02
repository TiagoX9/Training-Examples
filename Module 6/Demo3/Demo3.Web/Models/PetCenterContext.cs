using Microsoft.EntityFrameworkCore;

namespace Demo3.Web.Models
{
    public partial class PetCenterContext : DbContext
    {
        public PetCenterContext()
        {
        }

        public PetCenterContext(DbContextOptions<PetCenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }

        // Remove void OnConfiguring

        // OnModelCreating configures the entity relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.PersonId)
                    .IsUnique();

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Address)
                    .HasForeignKey<Address>(d => d.PersonId);
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Pet)
                    .HasForeignKey(d => d.PersonId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
