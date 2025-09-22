using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Struct
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 1300;
            rect1.width  = 10;
            Console.WriteLine("area of rect1:{0}", rect1.area());
            Rectangle rect2 = new Rectangle(100,67);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length:{0}",rect2.length);
            //Animals fox = new Animals()
            //{
            //    name = "red";
            //    sound = "raww"

            //};
            //Console.WriteLine("# of animals {0}", Animals.GetNumAnimals());
        }
        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l; width = w;
            }
            public double area()
            {
                return length * width;
            }
        }
    }
}
