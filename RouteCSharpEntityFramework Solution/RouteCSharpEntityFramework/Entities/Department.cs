using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFramework.Entities
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        public int MyProperty { get; set; }
    }
}
