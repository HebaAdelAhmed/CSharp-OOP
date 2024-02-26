using Microsoft.EntityFrameworkCore;
using RouteCSharpEntityFramework.Configration_Classes;
using RouteCSharpEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFramework.Contexts
{
    internal class EnterpriseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Integrated Security = true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigration());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Test> Tests { get; set; }
    }
}
