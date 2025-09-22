using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuall
{
    class animal
    {
        public  void Eat() => Console.WriteLine("animals eat food.");
    }
    class Dog : animal
    {
        public  void Eat() => Console.WriteLine("dogs bark");

    }
    class puppy : Dog
    {
        public void Eat() => Console.WriteLine("puppy weep-s");

    }
class virtuall
    {
        static void Main()
        {
        animal d1 = new Dog();
        animal p1 = new puppy();
        d1.Eat();
        p1.Eat();
        }
    }
}


