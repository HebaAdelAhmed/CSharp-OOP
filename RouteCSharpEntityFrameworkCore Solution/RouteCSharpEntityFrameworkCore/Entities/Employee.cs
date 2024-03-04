using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkCore.Entities
{

    /// Entity Framework Core Supports 4 Ways For Mapping (Classes To Database [Tables | Views]) -> Code First
    /// 1. By Convension -> (Default Behaviour)
    /// 2. Data Annotation -> (Set Of Attributes Used For Validation)
    /// 3. Fluent API (Context -> Override OnModelCreating) [If U Need To Make A Composet Primary Key , Default Value For A Column] Or [If I Have Not Sorce Code Of This Class]
    /// 4. Configration Class Per Entity -> Organize 3rd Way

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [AllowNull]
        [Column(TypeName = "MONEY")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Range(18, 25)]
        public int? Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        //Navigational Property => One
        public Department Department { get; set; }

    }
}
