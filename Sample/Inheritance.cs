using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class animal
    {
        public void Eat() => Console.WriteLine("animals eat food.");
    }
    class Dog : animal
    {
        public void Bark() => Console.WriteLine("dogs bark");

    }
    class puppy : Dog
    {
        public void weep() => Console.WriteLine("puppy weep-s");

    }
    class Inheritance
    {
        static void Main()
        {
            puppy p = new puppy();
            p.Eat();
            p.Bark();
            p.weep();   
        }
    }
}
