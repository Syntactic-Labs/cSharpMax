using System;

namespace GeoShapePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quad(5, 5, 5, 5);
            var r1 = new Rect(5, 5);
            var s1 = new Square(5);
            q1.Print();
        }
    }
}
