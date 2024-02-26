using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFramework.Entities
{

    /// <summary>
    /// POCO Class -> Is A Class That Contain Only Properties No Logic and No Functionalty
    /// Plain Old CLR Object
    /// 
    /// Entity Framework Core Supports 4 Ways For Mapping (Classes To Database [Tables | Views]) -> Code First
    /// 1. By Convension -> (Default Behaviour)
    /// 2. Data Annotation -> (Set Of Attributes Used For Validation)
    /// 3. Fluent API (Context -> Override OnModelCreating) [If U Need To Make A Composet Primary Key , Default Value For A Column] Or [If I Have Not Sorce Code Of This Class]
    /// 4. Configration Class Per Entity -> Organize 3rd Way
    /// </summary>

    /// 1. By Convension -> (Default Behaviour)


    ///internal class Employee
    ///{
    ///    public int Id { get; set; } // Public Numeric Property Named [Id | EmployeeId] , Idnentity Constraint(1 , 1)
    ///    public string Name { get; set; } // Reference Type : Allow Null (Optional) [NVARCHER(MAX)] 
    ///    public decimal Salary { get; set; } // Value Type  : Not Allow Null (Required)
    ///    public int? Age { get; set; } // Nullable<int>     : Allow Null (Optional) 
    ///}

    /// 2. Data Annotation -> (Set Of Attributes Used For Validation)

    //[Table("Employees")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; } // primary key cause of [Key]
        
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50 , MinimumLength = 5)]
        public string Name { get; set; }

        [AllowNull]
        [Column(TypeName = "MONEY")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Range(18 , 25)]
        public int? Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return $"{EmpId} :: {Name} :: {Salary} :: {EmailAddress}";
        }
    }



}
