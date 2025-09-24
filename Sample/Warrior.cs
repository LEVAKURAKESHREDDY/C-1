using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Warrior
    {
        public string Name {  get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public double BlockMax { get; set; }
        Random rnd = new Random();

        public Warrior(string name = "warrior",
            double health= 0,
            double attkmax = 0,
            double blockmax = 0 )
        {
            Name = name;   
            Health = health;
            AttkMax = attkmax;
            BlockMax = blockmax;
            
        }
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
