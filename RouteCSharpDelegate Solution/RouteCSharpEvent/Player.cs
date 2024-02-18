using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RouteCSharpEvent
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public override string ToString() => $"Player: {Name} , Team : {TeamName}";
        public void Run() => Console.WriteLine($"{this} Is Running....");
    }
}
