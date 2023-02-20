using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Classes
{
    public class Ranger : Hero
    {

        public Ranger (string name) : base(name)
        {

            LevelAttribute = new HeroAttributes(1, 7, 1);
            Name = name;
            ValidWeaponTypes.AddRange(new[] { WeaponType.Bow });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });

            // calculating DamageAttributes based on Dexterity  
            DamageAttribute = TotalAttributes().Dexterity;
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttribute.Strength += 1;
            LevelAttribute.Dexterity += 5;
            LevelAttribute.Intelligence += 1;
        }

    }
}
