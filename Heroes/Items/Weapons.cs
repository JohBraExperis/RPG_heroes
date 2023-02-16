using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Items
{ 

     public enum WeaponType
{
    Axes,
    Bows,
    Daggers,
    Hammers,
    Staffs,
    Swords,
    Wands
}

    public class Weapons : Item
    {

        public Weapons( string name, int requiredLevel, Slot equipmentSlot): base (name, requiredLevel, equipmentSlot)
        { 
        


        }

        public class WeaponDamage{}
    }
}
