using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class Weapons //Member Variables
    {
        string ChooseWeapon;

        string M4;
        string Name1;

        string ShotGun;
        string Name2;

        string Sniper;
        string Name3;

        string Rocketlaunch;
        string Name4;

        int Weapon1Damage;
        int Weapon2Damage;
        int Weapon3Damage;
        int Weapon4Damage;

        public Weapons() //Constructor
        {
            Name1 = M4;
            Name2 = ShotGun;
            Name3 = Sniper;
            Name4 = Rocketlaunch;
            Weapon1Damage = 20;
            Weapon2Damage = 35;
            Weapon3Damage = 75;
            Weapon4Damage = 100;
        }
        //Methods
        public void Trooper()
        {
            
        }

        public void Assault()
        {

        }

        public void Recon()
        {

        }

        public void Heavy()
        {

        }

    }

}
