using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box

{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }
        public Box()
        : this(1, 1, 1) { }

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box();
            {
                box.Length = box1.Length + box2.Length;
                box.Width = box1.Width + box2.Width;
                box.Breadth = box1.Breadth + box2.Breadth;
            }
            ;
            return box;
        }
        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box();
            {
                box.Length = box1.Length - box2.Length;
                box.Width = box1.Width - box2.Width;
                box.Breadth = box1.Breadth - box2.Breadth;
            }

            return box;

        }
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format(" box with height: {0} width {1} and Breadth {2}",Length ,Width,Breadth );
            
        }
        public static void Main(string[] args)
        {
            Box box1 = new Box(1,2,3);
            Box box2 = new Box(4,5,6);
            Box box3 = box1 + box2;
            Console.WriteLine($"box3 :{box3}");
        }
    }
}
