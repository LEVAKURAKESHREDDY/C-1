using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREADS

{
    class THREAD
    {

        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[10];
            Thread.CurrentThread.Name = "main";
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive{1}:",
                    threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive{1}:",
                    threads[i].Name, threads[i].IsAlive);
            }
            Console.WriteLine("current priority :{0}",
                Thread.CurrentThread.Priority);
            Console.WriteLine("thrad {0} Ending :{1}",
                Thread.CurrentThread.Name);

        }
    }
}
