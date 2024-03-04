using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkInheritence.Entities
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        [StringLength(50)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
