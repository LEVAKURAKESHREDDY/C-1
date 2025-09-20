using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilerandom
{
    class Dowhile
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretnumber = rnd.Next(1, 11);
            int numberguessed = 0;
           // Console.WriteLine("random number : ", secretnumber);
            do
            {
                Console.WriteLine("enter a number between 1 and 10 : ");
                numberguessed =  Convert.ToInt32(Console.ReadLine());
            } while (secretnumber != numberguessed);
            Console.WriteLine("you guess number is {0}", secretnumber);

        }
    }
}
