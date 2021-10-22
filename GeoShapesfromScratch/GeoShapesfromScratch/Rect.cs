using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapesfromScratch
{
    class Rect : Quad
    {
        public void Print()
        {
            Console.WriteLine($"The parimeter is {Parimeter()} and the area is {Area()}!");
        }
        public decimal Area()
        {
            return Side1 * Side2;
        }
        public Rect(decimal SideA, decimal SideB) : base (SideA, SideB, SideA, SideB)
        {

        }
    }
}
