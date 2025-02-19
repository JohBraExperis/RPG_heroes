﻿using RPG_heroes.Heroes.Attributes;
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

        public ArmorType ArmorTypes { get; set; }

        public HeroAttributes ArmorAttribute { get; set; }

        public Slot SlotType;


        public Armor(string name, int requiredLevel, Slot eqipmentSlot, ArmorType armorType, HeroAttributes armorAttribute): base(name, requiredLevel, eqipmentSlot) {

            ArmorAttribute = armorAttribute;
            ArmorTypes = armorType;
        }
  

    }
}
