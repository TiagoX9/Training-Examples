using Demo1.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Web.Data
{
    // 1. Inherit from DbContext
    public class CompanyDbContext : DbContext
    {
        // 2. Add properties
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        // 3. Add constructor
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }
    }
}
