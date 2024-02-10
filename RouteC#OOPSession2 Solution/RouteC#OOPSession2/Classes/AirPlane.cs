using RouteC_OOPSession2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Classes
{
    internal class AirPlane : IMoveable, IFlyable
    {
        void IFlyable.Backward()
        {
            Console.WriteLine("Backword On Air");
        }

        void IMoveable.Backward()
        {
            Console.WriteLine("Backword On Ground");
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
