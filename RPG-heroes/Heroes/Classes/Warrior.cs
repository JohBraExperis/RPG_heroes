using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Classes
{
    public class Warrior : Hero
    {

        public Warrior(string name) : base(name)
        {
            LevelAttribute = new HeroAttributes(5, 2, 1);
            Name = name;
            ValidWeaponTypes.AddRange(new[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Plate, ArmorType.Mail });

            // Setting the DamageAttribute to the total strength of the Warrior class  
            DamageAttribute = TotalAttributes().Strength;
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
