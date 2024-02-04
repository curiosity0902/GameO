using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        public string Name { get; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public void CalculateStats()
        {
            Strength = 10;
            Intelligence = 15;
            Agility = 12;
        }
    }
}
