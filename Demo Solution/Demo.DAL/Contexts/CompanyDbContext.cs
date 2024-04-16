using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext( DbContextOptions<CompanyDbContext> options ):base(options) 
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("Server = DESKTOP-AFMPLMB\\SQLEXPRESS01 ; Database = DemoCompanyDb ; Trusted_Connection = true ;");

        public DbSet<Department> Departments { get; set; }
    }
}
