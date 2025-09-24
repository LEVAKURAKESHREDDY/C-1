using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace arrrray 
{
    class Arraylistt
    {
        static void Main(string[] args)
        {
            
            ArrayList alist = new ArrayList();
            alist.Add("bob");
            alist.Add(20);

            Console.WriteLine("count:{0}", alist.Count);
            Console.WriteLine("capacity: {0}", alist.Capacity);

            ArrayList alist2 = new ArrayList();
            alist2.AddRange(new object[] { "mike, michel vokafda,nekendhuku , hasthala vestha" });
            alist.AddRange(alist2);
            alist.Sort();
            alist2.Reverse ();
            alist.Insert(1, "kadapa");
            alist2.RemoveAt (1);
            alist2.RemoveRange (0, 2);
            Console.WriteLine("kadapa Index:{0}", alist2.IndexOf("kadapa", 1)); 

        }
    }
}
