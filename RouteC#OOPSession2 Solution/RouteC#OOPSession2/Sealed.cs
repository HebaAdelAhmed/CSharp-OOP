using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2
{
    internal class Parent
    {

    }
    class Child : Parent
    {

    }
    sealed class GrandChild : Child  // No Class Can Exttend This Class
    {

    }
}
