using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class RoBot
    {//Member Variables //name, health, power level, and a Weapon with a type (i.e. sword) and attack power.

        string Botname;
        bool HasHealth;
        bool HasEnergy;
        int BotHP;
        int BotEnergy;
        double BotMana;
        string BotWeapon;
        int AttackPower;
        bool IsActive;

                                         //Constructor
        public RoBot(string BotName, int BotHp, double BotEnergy, bool HasHealth, bool HasEnergy, bool Isactive, int AttackPower, string Botweaponname) 
        {
                 //Why do these name have to be different from the method signiture?
            BotName = "Name"; 
            BotHp = (0);
            BotEnergy = (0);
            HasHealth = true;
            HasEnergy = true;
            Isactive = true;
            Botweaponname = null;
            AttackPower = (0);

        }

                              //Methods/If Statements
        public void ChooseAttack()
        {
           
        }
                            //Instantiation
        RoBot Assault = new RoBot("Striker", 200, 300, true, true, true, 25, "Rifle");
        RoBot Shock = new RoBot("Shocker", 250, 250, true, true, true, 35, "Shotgun");
        RoBot Recon = new RoBot("Shadow", 150, 200, true, true, true, 50, "Sniper");
        RoBot Wrecker = new RoBot("Barricade", 350, 150, true, true, true, 100, "RocketLauncher");
    }
}
