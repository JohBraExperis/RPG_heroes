using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Classes;
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
        public int DamageAttribute { get; set; }

        public Dictionary<Slot, Item> Equipment;
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }
        public HeroAttributes LevelAttribute { get; set; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;

            // setting initial null values to equipment
            Equipment.Add(Slot.Weapon, null);
            Equipment.Add(Slot.Head, null);
            Equipment.Add(Slot.Body, null);
            Equipment.Add(Slot.Legs, null);

            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
        }

        // This LevelUp method gets overidden in the child.
        public abstract void LevelUp();

        public HeroAttributes TotalAttributes()
        {

            int Strength = 0;
            int Dexterity = 0;
            int Intelligence = 0;

            foreach (Item item in Equipment.Values)
            {
                if (item is Armor)
                {
                    Armor armor = (Armor)item;
                    Strength += armor.ArmorAttribute.Strength;
                    Dexterity += armor.ArmorAttribute.Dexterity;
                    Intelligence += armor.ArmorAttribute.Intelligence;

                }
            }

            Strength += LevelAttribute.Strength;
            Dexterity += LevelAttribute.Dexterity;
            Intelligence += LevelAttribute.Intelligence;
            HeroAttributes TotalAttributes = new(Strength, Dexterity, Intelligence);

            return TotalAttributes;
        }

        public  void Equip(Item item)
        {
            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.RequiredLevel >= Level)

                {
                    throw new Exeptions.InvalidLevelExeption();
                }


                if (!ValidArmorTypes.Contains(armor.armorType))
                {
                    throw new Exeptions.InvalidArmorExeption();
                }
            }


            if (item is Weapons)
            {
                Weapons weapons = (Weapons)item;
                if (weapons.RequiredLevel >= Level)

                {
                    throw new Exeptions.InvalidLevelExeption();
                }


                if (!ValidWeaponTypes.Contains(weapons.weaponType))
                {
                    throw new Exeptions.InvalidArmorExeption();
                }
            }

            Equipment.Remove(item.EquipmentSlot);
            Equipment.Add(item.EquipmentSlot, item);

        }

        public int HeroDamage()
        {
            int HeroDamage = 0;

            if (Equipment.ContainsKey(Slot.Weapon))
            {
                Weapons weapon = (Weapons)Equipment[Slot.Weapon];
                HeroDamage = weapon.WeaponDamage * (1 + DamageAttribute / 100);
            }
            else
            {
                HeroDamage = 1 + DamageAttribute / 100;
            }

            return HeroDamage;

        }

        // Method containing a stringBuilder to display Hero specs.
        public void HeroDisplay()
        {

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hero name: " + Name);
            stringBuilder.Append("Class: " + GetType());
            stringBuilder.Append("Level: " + Level);
            stringBuilder.Append(TotalAttributes().Strength);
            stringBuilder.Append(TotalAttributes().Dexterity);
            stringBuilder.Append(TotalAttributes().Intelligence);
            stringBuilder.Append(HeroDamage());

            Console.WriteLine(stringBuilder);

        }

    }
}