﻿using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Dictionary<Slot, Item> Equipment;
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }
        public HeroAttributes LevelAttribute { get; set; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;



            Equipment.Add(Slot.Weapon, null);
            Equipment.Add(Slot.Head, null);
            Equipment.Add(Slot.Body, null);
            Equipment.Add(Slot.Legs, null);


            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
        }

        // This LevelUp method gets overidden in the child.
        public abstract void LevelUp();

        public abstract void Equip()
        {

        }



    }
}