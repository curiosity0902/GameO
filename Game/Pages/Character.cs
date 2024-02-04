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

        private int _vitality;
        public int Vitality
        {
            get => _vitality;
            set
            {
                if (value > MaxVitality)
                    _vitality = MaxVitality;
                else
                    _vitality = value;
            }
        }

        private int _strength;
        public int Strength
        {
            get => _strength;
            set
            {
                if (value > MaxStrength)
                    _strength = MaxStrength;
                else
                    _strength = value;
            }
        }
        private int _dexterity;
        public int Dexterity
        {
            get => _dexterity;
            set
            {
                if (value > MaxDexterity)
                    _dexterity = MaxDexterity;
                else
                    _dexterity = value;
            }
        }
        private int _intelegence;
        public int Intelegence
        {
            get => _intelegence;
            set
            {
                if (value > MaxIntelegence)
                    _intelegence = MaxIntelegence;
                else
                    _intelegence = value;
            }
        }
        public virtual double Heath { get; set; }
        public virtual double Manna { get; set; }
        public Character(string name, int strenght, int maxStrenght, int dexterity, int maxDexterity, int intelegence, int maxIntelegence, int vitality, int maxVitality)
        {
            name = Name;
            strenght = _strength;
            maxStrenght = MaxStrength;
            dexterity = _dexterity;
            maxDexterity = _dexterity;
            intelegence = _intelegence;
            maxIntelegence = MaxIntelegence;
            vitality = _vitality;
            maxVitality = MaxVitality;           
        }


        public void GetAttributsWarrrior()
        {
            Heath = Vitality * 2 + Strength;
            Manna = Intelegence;
        }

        public void GetAttributsWizard()
        {
            Heath = Vitality * 1.4 + 0.2 * Strength;
            Manna = 1.5 * Intelegence;
        }
    }
}
