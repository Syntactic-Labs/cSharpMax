using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPClippers
{
    class Square : Rect
    {
        public Square(int SideA) : base(SideA, SideA)
        {

        }
        public new void Print()
        {
            Console.WriteLine($"The area of the Square is {Area()} and the parameter is {Parameter()}");
        }
    }
}
