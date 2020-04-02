using Demo4.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo4.Web.Data
{
    public class HrManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        // DEMO 4 PART 2
        public DbSet<EmployeeWithTotalHours> EmployeesWithTotalHours { get; set; }

        public HrManagementContext(DbContextOptions<HrManagementContext> options) : base(options)
        {

        }

        // DEMO 4 PART 2
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // EF Core doesn't know how to create views so we assign the one we are creating to it
            modelBuilder.Entity<EmployeeWithTotalHours>().HasNoKey().ToView("EmployeesWithTotalHours");
        }
    }
}
