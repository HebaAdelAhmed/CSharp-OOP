using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteCSharpEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFramework.Configration_Classes
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> E)
        {
            E.ToTable("Departments");

            E.HasKey(D => D.DeptId); // Primary Key

            //E.HasKey(nameof(Department.DeptId)); // Primary Key

            E.Property(D => D.DeptId)
                .UseIdentityColumn(10, 10);

            E.Property(D => D.Name)
                .HasMaxLength(100)
                .IsRequired(true)
                .HasColumnType("NVARCHAR")
                .HasColumnName("DeptName");

            E.Property(D => D.DateOfCreation)
                 .HasDefaultValue(DateTime.Now);
        }
    }
}
