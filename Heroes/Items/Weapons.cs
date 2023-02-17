using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Items
{ 

     public enum WeaponType
{
    Axe,
    Bow,
    Dagger,
    Hammer,
    Staff,
    Sword,
    Wand
}


    public class Weapons : Item
    {
        public WeaponType WeaponTypes { get; set; }

        public double WeaponDamage { get; set; }

        public Weapons( string name, int requiredLevel, Slot equipmentSlot, double weaponDamage, WeaponType weaponType): base (name, requiredLevel, equipmentSlot)
        { 
           WeaponDamage = weaponDamage;
           WeaponTypes = weaponType;
        }
    }
}
