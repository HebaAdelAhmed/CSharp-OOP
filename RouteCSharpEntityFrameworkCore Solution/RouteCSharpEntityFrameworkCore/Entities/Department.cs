using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkCore.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        //Navigational Property => Many
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        //public Department()
        //{
        //    Employees = new HashSet<Employee>();
        //}
    }
}
