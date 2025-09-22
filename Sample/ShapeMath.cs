using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class ShapeMath
    {
        public static double GetArea(string shape = "",
            double length1 = 0,
            double length2 = 0)
        {
            if(string.Equals("rectangle",shape,StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (string.Equals("triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2/2);
            }else if (string.Equals("circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14 * Math.Pow(length1,2);
            }
            else
            {
                return -1;
            }



        }
    }
}
