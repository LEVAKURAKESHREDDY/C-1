using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Animals
    {
        public string name;
        public string sound;
        static int noofanimals = 0;
        public Animals()
        {
            name = "no name";
            sound = "no sound";
            noofanimals++;

        }
        public Animals(string name = "no name")
        {
            this.name = name;
            this.sound = "no sound";
            noofanimals++;

        }
    }
}
