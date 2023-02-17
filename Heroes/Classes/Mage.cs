using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Classes
{
    public class Mage : Hero
    {
        public Mage (string name): base (name) 
        {
            Name = name;

            // constructing the LevelAttribute as HeroAttributes.
            LevelAttribute = new HeroAttributes(1, 1, 8);

            // adding valid weapons and armor to the lists
            ValidWeaponTypes.AddRange(new[] { WeaponType.Staff, WeaponType.Wand });
            ValidArmorTypes.AddRange(new[] { ArmorType.Cloth });

            // calculating DamageAttributes based on intelligence  
            DamageAttribute = TotalAttributes().Intelligence;
        }

        // Adding 
    public override void LevelUp()
        {
            Level += 1;
            LevelAttribute.Strength += 1;
            LevelAttribute.Dexterity += 1;
            LevelAttribute.Intelligence += 5;
        }

    }
}
