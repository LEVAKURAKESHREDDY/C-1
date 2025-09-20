using System;
namespace foreachloop
{
    class Foreach
    {
        static void Main(string[] args)
        {
            String[] cars = new string[5];
            cars[0] = "bmw";
            cars[1] = "volvo";
            cars[2] = "benze";
            cars[3] = "audi";
            cars[4] = "innpovwe";
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}

