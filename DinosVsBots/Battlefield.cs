using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{

    public class Battlefield
    { //Member Variables
        Herd JurrassicHurt;
        Fleet MechArmy;





        public Battlefield()
        { //Constructor
            this.MechArmy = new Fleet();
            this.JurrassicHurt = new Herd();
            StartBattle();
            Fight();
            Console.ReadLine();
        

        }

        public void StartBattle()
        {

            Console.WriteLine("The War Has Begun");
            

        }

        public void Fight()
        {
            while(JurrassicHurt.DeadDinoBot != true && MechArmy.Shutdown != true)
            {
                for (int i = 0; i < JurrassicHurt.Dinobots.Count; i++)
                {

                    JurrassicHurt.Dinobots[i].AttackMethod(MechArmy.ROBOS[0]);
                    Console.WriteLine("Your Dinos Have Attacked!");
                    
                }
                for (int i = 0; i < MechArmy.ROBOS.Count; i++)
                {
                    MechArmy.ROBOS[i].battleplan(JurrassicHurt.Dinobots[0]);
                    Console.WriteLine("The Imperial Mech Army Has Attacked!");
                    Console.ReadLine();
                }

                MechArmy.RobotStatusSync();
                JurrassicHurt.StatusSyncforDinos();
                


            }            
            
        }


    }
}
