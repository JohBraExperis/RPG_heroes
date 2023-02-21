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
        public double DamageAttribute { get; set; } = 0;

        public Dictionary<Slot, Item?> Equipment = new Dictionary<Slot, Item?>();
        public List<WeaponType> ValidWeaponTypes { get; set; } = new List<WeaponType>();
        public List<ArmorType> ValidArmorTypes { get; set; } = new List<ArmorType>();
        public HeroAttributes LevelAttribute { get; set; } = new HeroAttributes(1, 1, 1);

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

            double Strength = 0;
            double Dexterity = 0;
            double Intelligence = 0;

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

        public void Equip(Item item)
        {
            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.RequiredLevel > Level)

                {
                    throw new Exeptions.InvalidLevelExeption();
                }


                if (!ValidArmorTypes.Contains(armor.ArmorTypes))
                {
                    throw new Exeptions.InvalidArmorExeption();
                }
            }


            if (item is Weapons)
            {
                Weapons weapons = (Weapons)item;
                if (weapons.RequiredLevel > Level)

                {
                    throw new Exeptions.InvalidLevelExeption();
                }


                if (!ValidWeaponTypes.Contains(weapons.WeaponTypes))
                {
                    throw new Exeptions.InvalidWeaponExeption();
                }
            }

            Equipment.Remove(item.EquipmentSlot);
            Equipment.Add(item.EquipmentSlot, item);

        }

        public double HeroDamage()
        {
            double HeroDamage = 1;

            switch (this)
            {
                case Mage:
                    DamageAttribute = TotalAttributes().Intelligence;
                    break;

                case Ranger:
                    DamageAttribute = TotalAttributes().Dexterity;
                    break;

                case Rogue:
                    DamageAttribute = TotalAttributes().Dexterity;
                    break;

                case Warrior:
                    DamageAttribute = TotalAttributes().Strength;
                    break;
            }

            if (Equipment[Slot.Weapon] != null)
            {
                Weapons weapon = (Weapons)Equipment[Slot.Weapon];
                HeroDamage = weapon.WeaponDamage * (1 + DamageAttribute / 100);
                Console.WriteLine(weapon.WeaponDamage);
                Console.WriteLine(DamageAttribute);
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

            stringBuilder.AppendLine("Hero name: " + Name);
            stringBuilder.AppendLine("Class: " + GetType().Name);
            stringBuilder.AppendLine("Level: " + Level);
            stringBuilder.AppendLine("Strength: " + TotalAttributes().Strength);
            stringBuilder.AppendLine("Dexterity: " + TotalAttributes().Dexterity);
            stringBuilder.AppendLine("Intelligence: " + TotalAttributes().Intelligence);
            stringBuilder.AppendLine("Damage: " + HeroDamage());

            Console.WriteLine(stringBuilder);

        }

    }
}