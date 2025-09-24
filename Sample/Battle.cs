using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Battle
    {
        //startfight
        //war1 attacks war2, war2 is damaged and health decreses
        //get result
        //war2 attacks war1, war2 is damaged and health decreses
        //get attack result
        public static void StratFight(Warrior Warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackresult(Warrior1, warrior2) == "game over")
                {
                    Console.WriteLine("game over");
                    break;
                }
            }
        }

        public static string GetAttackresult(Warrior warriorA, Warrior warriorB )
        {
            double warAattkAmt = warriorA.Attack();
            double warBBlokAmt = warriorB.Block();
            double dmg2warB = warAattkAmt - warBBlokAmt;

            if (dmg2warB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2warB;

            }
            else dmg2warB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
              warriorA.Name,
              warriorB.Name,
              dmg2warB);
            Console.WriteLine("{0} Has {1} health\n",
              warriorB.Name,
              warriorB.Health ,
              dmg2warB);
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorous\n",
              warriorA.Name,
              warriorB.Name);
                return "game over";

            }
            else return "fight again";
              
            
        }
    }
}
