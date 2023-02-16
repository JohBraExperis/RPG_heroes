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
            LevelAttribute = new HeroAttributes(1, 1, 8);
            Name = name;
            ValidWeaponTypes.AddRange(new[] { WeaponType.Staffs, WeaponType.Wands });
            ValidArmorTypes.AddRange(new[] { ArmorType.Cloth });
        }

    public override void LevelUp()
        {
            Level += 1;
            LevelAttribute.Strength += 1;
            LevelAttribute.Dexterity += 1;
            LevelAttribute.Intelligence += 5;
        }

    }
}
