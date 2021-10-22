using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPClippers
{
    class Rect : Quad
    {
        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)
        {

        }
        public int Area()
        {
            return Side1 * Side2;
        }
        public new void Print()
        {
            Console.WriteLine($"The area of the Rect is {Area()} and the parameter is {Parameter()}");
        }
    }
}
