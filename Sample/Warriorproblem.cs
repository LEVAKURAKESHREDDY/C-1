using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace war
{
    class Warriorproblem
    {
        static void Main(string[] args)
        {

            Warrior cbn = new Warrior("cbn", 100, 25, 10);
            Warrior pawan = new Warrior("pawan", 100, 25, 10);
            Battle.StratFight(cbn, pawan);
        }
    }
}
