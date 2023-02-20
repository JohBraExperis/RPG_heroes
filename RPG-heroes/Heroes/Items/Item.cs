using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Items
{

    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    public class Item
    {
       public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot EquipmentSlot { get; set; }

        public Item(string name, int requiredLevel, Slot equipmentSlot) 
        {
            Name = name;
            RequiredLevel = requiredLevel;
            EquipmentSlot = equipmentSlot;

        }

    }
}
