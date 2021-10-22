using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapePrac
{
    class Quad
    {
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Side3 { get; set; }
        public decimal Side4 { get; set; }

        public decimal Parimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
        public void Print()
        {
            Console.WriteLine($"Parimeter is {Parimeter()}");
        }

        public Quad(decimal Side1, decimal Side2, decimal Side3, decimal Side4)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
            this.Side4 = Side4;
        }






    }
    
    
    
}
