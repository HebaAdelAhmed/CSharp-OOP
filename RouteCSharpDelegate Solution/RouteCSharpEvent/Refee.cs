using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEvent
{
    internal class Refee
    {
        public string Name { get; set; }
        public override string ToString() => $"Refree : {Name}";
        public void Look() => Console.WriteLine($"{this} , Is Looking....");
    }
}
