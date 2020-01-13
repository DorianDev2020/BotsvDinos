using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class RoBot
    {//Member Variables //name, health, power level, and a Weapon with a type (i.e. sword) and attack power.

       public string Botname;
       public int BotHP;
       public int BotEnergy;
       public int AttackPower;
       public Weapons weapons;
            
      

                      //This blueprint is basically giving the object its "Bones" its the most basic things about the object youre trying to create.                   
        public RoBot (string Botname, int BotHP, int BotEnergy, int AttackPower) 
        {
                 
            this.Botname = null; 
            this.BotHP = (0);
            this.BotEnergy = (0);
            this.AttackPower = (0);
            this.weapons = new Weapons("Blaster");

            //DO NOT INSTANTIATE THE OBJECT IN ITS SAME CLASS! this will cause a stack overload (or an infinite loop basically).

        }

        public void battleplan(Dinos dinos)
        {

            dinos.DinoHP -= AttackPower + weapons.WeaponDamage;
        }
        
    }
}
