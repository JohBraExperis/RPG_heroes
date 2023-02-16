using RPG_heroes.Heroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Items
{

    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }

    public class Armor : Item
    {

        public HeroAttributes ArmorAttribute { get; set; }


        public Armor(string name, int requiredLevel, Slot eqipmentSlot): base(name, requiredLevel, eqipmentSlot) {

            ArmorAttribute = new HeroAttributes(1, 1, 1);
        }
  

    }
}
