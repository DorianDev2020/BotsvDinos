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


        //Constructor
        public Fleet()
        {
            ROBOS = new List<RoBot>();
            ROBOS.Add(new RoBot("BB001", 200, 150, 20));
            ROBOS.Add(new RoBot("BB002", 250, 200, 25));
            ROBOS.Add(new RoBot("BB003", 300, 100, 75));



        }
    }

    


   



    

    
}
