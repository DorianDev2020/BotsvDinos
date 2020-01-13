using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class Fleet
    {

       public RoBot BB001 = new RoBot("BB001", 400, 300, 50);
       public RoBot BB002 = new RoBot("BB002", 500, 250, 75);
       public RoBot BB003 = new RoBot("BB003", 450, 200, 100);
       public List<RoBot> ROBOS;
       public bool Shutdown;


        //Constructor
        public Fleet()
        {
            ROBOS = new List<RoBot>();
            ROBOS.Add(new RoBot("BB001", 200, 150, 20));
            ROBOS.Add(new RoBot("BB002", 250, 200, 25));
            ROBOS.Add(new RoBot("BB003", 300, 100, 75));
            Shutdown = true;


        }


        public void RobotStatusSync()
        {
            for (int i = 0; i < ROBOS.Count; i++)
            {
                if (ROBOS[i].BotHP <= 0)
                {

                    ROBOS.Remove(ROBOS[i]);
                    i--;
                    Console.WriteLine("Your WarBot has been Deactivated");
                   

                }
            }

            if (ROBOS.Count == 0)
            {
                Shutdown = true;
            }
        }
    }

    


   



    

    
}
