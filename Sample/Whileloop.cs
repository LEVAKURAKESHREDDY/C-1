using System;
namespace whileloop
{
    class Whileloop
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 10)
            {
                if(i == 6)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
      
    }
}
