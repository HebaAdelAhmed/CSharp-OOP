using Microsoft.EntityFrameworkCore;

namespace DemoITI.Models.Contexts
{
    public class DemoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = DemoITIDb; Integrated Security = true");
            
        }

        public DemoContext():base()
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
