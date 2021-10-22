using System;

namespace GeoShapesfromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Q1 = new Quad(5, 5, 5, 5);
            var R1 = new Rect(5, 5);
            var S1 = new Square(5);
            Q1.print();
            R1.Print();
            S1.Print();
        }
    }
}
