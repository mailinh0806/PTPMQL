using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee {get; set;}
        public DbSet<HeThongPhanPhoi> HeThongPhanPhois {get; set;}
        public DbSet<Daily> Daily {get; set;}
    }
}
