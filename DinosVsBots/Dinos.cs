﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class Dinos
                                                        //member Variables
    {
        public string Dinoname;
        public int DinoHP;
        public int DinoEnergy;
        public int Attackpower;
        public Weapons weapons;

        public Dinos(string Dinoname, int DinoHP, int DinoEnergy, int Attackpower, string DinoWeaponName)
        {
            this.Dinoname = null;
            this.DinoHP = (0);
            this.DinoEnergy = (0);
            this.Attackpower = (75);
            this.weapons = new Weapons("Bite");
        }         
        

        public void AttackMethod(RoBot roBot)
        {
            roBot.BotHP -= Attackpower + weapons.WeaponDamage;

        }

        
        
    }
                                                           
    
   
    
}
