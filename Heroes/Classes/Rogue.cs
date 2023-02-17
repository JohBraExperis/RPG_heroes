using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Classes
{
    public class Rogue : Hero
    {

        public Rogue(string name) : base(name)
        {

            LevelAttribute = new HeroAttributes(2, 6, 1);
            Name = name;
            ValidWeaponTypes.AddRange(new[] { WeaponType.Daggers, WeaponType.Swords  });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });

            // Setting the DamageAttribute to the total dexterity of the Rogue class  
            DamageAttribute = TotalAttributes().Dexterity;
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttribute.Strength += 1;
            LevelAttribute.Dexterity += 4;
            LevelAttribute.Intelligence += 1;
        }
    }
}
