using System;
namespace arrayss
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] Oddnumbers = new int[4];
            string[] names = new string[5];
            names[0] = "hello";
            names[1] = "nani";

            Oddnumbers[0] = 100;
            Oddnumbers[1] = 101;
            Oddnumbers[2] = 102;
            Oddnumbers[3] = 103;
            Console.WriteLine(Oddnumbers[1]);
            Console.WriteLine(names[1]);
        }
    }
}

