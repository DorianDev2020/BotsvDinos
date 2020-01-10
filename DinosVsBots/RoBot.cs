using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class RoBot
    {//Member Variables

        string Botname;
        bool HasHealth;
        bool HasEnergy;
        int BotHP;
        int BotEnergy;
        double BotMana;

                                         //Constructor
        public RoBot(string BotName, int BotHp, double BotEnergy, bool HasHealth, bool HasEnergy) 
        {
                 //Why do these name have to be different from the method signiture?
            BotName = "Name"; 
            BotHp = (0);
            BotEnergy = (0);
            HasHealth = true;
            HasEnergy = true;
        }
        public void ChooseAttack()
        {
           
        }
                            //Instantiation
        RoBot Assault = new RoBot("Striker", 200, 300, true, true);
        RoBot Shock = new RoBot("Shocker", 250, 250, true, true);
        RoBot Recon = new RoBot("Shadow", 150, 200, true, true);
        RoBot Wrecker = new RoBot("Barricade", 350, 150, true, true);  
    }
}
