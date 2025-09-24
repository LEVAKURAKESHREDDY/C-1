using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que
{
     class Ququeee
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("1 in queue ::{0}",
                queue.Contains(1));
            Console.WriteLine("Remove:{0}",
                queue.Dequeue ());
            Console.WriteLine("peek 1:{0}",
                queue.Peek());
            object[] numarray = queue.ToArray ();
            Console.WriteLine(String.Join (",", numarray));
            foreach (object o in queue )
            {
                Console.WriteLine($"Queue:{o}");
            }
            queue.Clear ();


        }
    }
}
