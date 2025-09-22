using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesss
{
    
    
        interface ivechical
        {
            void drive();
            void refuel();

        }

    class bike : ivechical
    {
        public void drive()
        {
            Console.WriteLine("bike os two wheller");
        }
        public void refuel()
        {
            Console.WriteLine("bike is refueled with petrol");
        }
    }
    class car : ivechical
    {
        public void drive()
        {
            Console.WriteLine("car has 4 wheller");
        }
        public void refuel()
        {
            Console.WriteLine("car is refueled with petrol");
        }

    }
    class Interfacess
    {
        static void Main(string[] args)
        {
            ivechical bikeee = new bike();
            ivechical carsss = new car();
            bikeee.drive();
            carsss.drive();
            carsss.refuel();
            bikeee .refuel();
        }
    }
}

