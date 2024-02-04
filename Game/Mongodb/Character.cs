using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxVitality { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxStrength { get; set; }
        public int MaxIntelegence { get; set; }
        public int Vitality { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }   
        public int Intelegence { get; set; }
     
        public double Heath { get; set; }
        public double Manna { get; set; }
        public Character(string name, int strenght, int maxStrenght, int dexterity, int maxDexterity, int intelegence, int maxIntelegence, int vitality, int maxVitality, double health, double manna)
        {
            Name = name;
            Strenght = strenght;
            MaxStrength = maxStrenght;
            Dexterity = dexterity;
            MaxDexterity = maxDexterity;
            Intelegence = intelegence;
            MaxIntelegence = maxIntelegence;
            Vitality = vitality;
            MaxVitality = maxVitality;
            Heath = health;
            Manna = manna;
            
        }


        public void GetAttributsWarrrior()
        {
            Heath = Vitality * 2;
            Manna = Intelegence;
        }

        public void GetAttributsWizard()
        {
            Heath = Vitality * 1.4 + 0.2;
            Manna = 1.5 * Intelegence;
        }
    }
}
