using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapePrac
{
    class Rect : Quad
    {
        public decimal Area()
        {
            return Side1 * Side2;
        }
    }
}
