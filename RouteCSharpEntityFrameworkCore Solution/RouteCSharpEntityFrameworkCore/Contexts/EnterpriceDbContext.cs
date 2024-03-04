using Microsoft.EntityFrameworkCore;
using RouteCSharpEntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkCore.Contexts
{
    internal class EnterpriceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server = DESKTOP-AFMPLMB\\SQLEXPRESS01 ; Database = EnterpriseDb ; Trusted_Connection = true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(E => E.Department)
                .WithMany(D => D.Employees)
                .HasForeignKey(E => E.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId , SC.CourseId }); // Composite PK

            ///modelBuilder.Entity<Department>()
            ///    .HasMany(D => D.Employees)
            ///    .WithOne(E => E.Department)
            ///    .HasForeignKey(E => E.DepartmentId)
            ///    .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
