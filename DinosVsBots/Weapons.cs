using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    public class Weapons
    {
        public string WeaponName;
        public int WeaponDamage;
       

        public Weapons(string WeaponName)
        {
            this.WeaponName = WeaponName;
            WeaponDamage = 50;
        }
        // "This" basically ties the variable to THAT specific parameter
        // Wheres as not putting "This" leaves it more fluid.
        

        
        
        
        
    }


}
