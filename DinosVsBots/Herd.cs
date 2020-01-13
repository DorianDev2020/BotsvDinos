using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class Herd
    {
        Dinos IndominousWrecks = new Dinos("Indominous Wrecks", 300, 100, 100, "Vicious Bite");
        Dinos Terrorsaur = new Dinos("Terrorsaur", 200, 150, 20, "Claw");
        Dinos Stegosaur = new Dinos("Stegosaur", 250, 200, 25, "Tail Swipe");
        public bool DeadDinoBot; 
        public List<Dinos> Dinobots;

        public Herd()
        {

            Dinobots = new List<Dinos>();
            Dinobots.Add(new Dinos("Terrorsaur", 200, 150, 20,"Claw" ));
            Dinobots.Add(new Dinos("Stegosaur", 250, 200, 25, "Tail Swipe"));
            Dinobots.Add(new Dinos("Indominous Wrecks", 300, 100, 100, "Vicious Bite"));
        }

        public void StatusSyncforDinos()
        {

            for (int i = 0; i < Dinobots.Count; i++)
            {
                if (Dinobots[i].DinoHP <= 0)
                {
                    Dinobots.Remove(Dinobots[i]);
                    i--;
                    Console.WriteLine("Your Dino Has Been Defeated");
                }
                


            }

            if (Dinobots.Count == 0)
            {
                DeadDinoBot = true;
            }

        }

    }
}
