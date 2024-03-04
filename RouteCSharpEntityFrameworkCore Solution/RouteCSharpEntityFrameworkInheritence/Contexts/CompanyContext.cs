using Microsoft.EntityFrameworkCore;
using RouteCSharpEntityFrameworkInheritence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkInheritence.Contexts
{
    internal class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
             optionsBuilder.UseSqlServer("Server = DESKTOP-AFMPLMB\\SQLEXPRESS01 ; Database = CompanyDb ; Trusted_Connection = true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // TPH : Map FullTimeEmployee And PartTimeEmployee To One Table Called "Employees"
            // Add New Column NVARCHAR In Table Named As Discrimintor Containing The Type Of Employee [FulltimeEmployee || PartTimeEmployee]
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
