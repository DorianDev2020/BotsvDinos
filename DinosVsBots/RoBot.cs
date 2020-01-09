using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsBots
{
    class Bots 
    {//Member Variables

        string Bot1Name;
        string Bot2Name;
        string Bot3Name;
        string Bot4Name;
        
        bool HasHealth;
        bool HasMana;

        int TrooperHP;
        int AssaultHP;
        int ReconHP;
        int HeavyHP;

        Double TrooperMana;
        Double AssaultMana;
        Double ReconMana;
        Double HeavyMana;

        public Bots() //Constructor
        {
            Bot1Name = ("Striker");
            Bot2Name = ("Shocker");
            Bot3Name = ("Zero");
            Bot4Name = ("Berserker");

            TrooperHP = (200);
            AssaultHP = (300);
            ReconHP = (250);
            HeavyHP = (325);

            TrooperMana = (300);
            AssaultMana = (275);
            ReconMana = (200);
            HeavyMana = (150);

            HasHealth = true;
            HasMana = true;
        }

        public void ChooseYourBot()//Methods
        {
            string Bot1name(int TrooperHP, int TrooperMana);
            HasMana = true;
            HasHealth = true;
            Console.WriteLine("Striker!");
            Bot1Name = (Console.ReadLine());

           
            string Bot2name(int AssaultHP, int AssaultMana);
            Console.WriteLine("Shocker!");
            Bot2Name = (Console.ReadLine());
            HasMana = true;
            HasHealth = true;


            string Bot3name(int ReconHP, int ReconMana);
            Console.WriteLine("Zero!");
            Bot3Name = (Console.ReadLine());
            HasHealth = true;
            HasMana = true;


            
            string Bot4name(int HeavyHP, int HeavyMana);
            Console.WriteLine("Berzerker!");
            Bot4Name = (Console.ReadLine());
            HasMana = true;
            HasHealth = true;


        }
        
        
        
        
        
        
    }
}
