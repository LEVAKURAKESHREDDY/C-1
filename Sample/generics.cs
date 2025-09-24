using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gen.generics.Rectangle<int>;

namespace gen
{
    class generics
    {
        static void Main(string[] args)
        {
            List<genericanimal> animallist = new List<genericanimal>();
            List<int> numlist = new List<int>();
            numlist .Add(67);
            animallist.Add(new genericanimal() { Name = " dog" });
            animallist.Add(new genericanimal() { Name = " cat" });

            animallist.Add(new genericanimal() { Name = " Deer" });
            animallist.Insert(0, new genericanimal() { Name = "nekendhuku" });
            animallist.RemoveAt(1);
            Console.WriteLine("Num of Animals :{0}",
                animallist.Count());
            foreach(genericanimal a in animallist)
            {
                Console.WriteLine(a.Name);
            }
            int x=5 , y=8 ;
            genericanimal.GetSum<int>(ref x, ref y);
            string strX = "5", strY = "8";
            genericanimal.GetSum<string >(ref strX, ref strY);
            Rectangle<int>rec1 = new Rectangle<int>(20,70);
            Console.WriteLine(rec1.GetArea());
            Rectangle<string> rec2 = new Rectangle<string>("20", "70");
            Console.WriteLine(rec2.GetArea());

            Arithmetic add, sub, addsub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addsub = add + sub;
            Console.WriteLine($"Add {6} & {4}");
            add(6, 4);
            Console.WriteLine($"Add & Subtract {6} & {4} ");
            addsub(6, 4);
        }
        public struct Rectangle<T>
        {
            private T length;
            private T width;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }
            public T Length
            {
                get { return length; }
                set { length = value; }

            }
            public Rectangle(T w,T l)
            {
                width = w;
                length = l;
            }
            public string GetArea()
            {
                double dblwidth = Convert .ToDouble (Width);
                double dbllength = Convert .ToDouble (Length);
                return string.Format($"{width}*{length} = {dbllength * dbllength}");
            }
            public delegate void Arithmetic(double num1 , double num2);
            public static void Add(double num1, double num2)
            {
                Console.WriteLine($"{num1} + {num2}= {num1 + num2}");
            }
            public static void Subtract(double num1, double num2)
            {
                Console.WriteLine($"{num1} - {num2}= {num1 - num2}");
            }

        }
        
    }
}
