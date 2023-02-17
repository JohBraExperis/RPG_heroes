using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Attributes
{
    public class HeroAttributes
    {

        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }

        public HeroAttributes(double strength, double dexterity, double intelligence) {

            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

        }

    }
}
