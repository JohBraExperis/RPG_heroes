using RPG_heroes.Exeptions;
using RPG_heroes.Heroes.Classes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest

{
    public class ExeptionTests
    {

        [Fact]
        public void InvalidArmorExeption_Equip_ShouldThrowExeption()
        {
            Armor armor = new Armor("Plate", 1, Slot.Body, ArmorType.Plate, new(2, 2, 2));
            Rogue rogue = new Rogue("James");

            Assert.Throws<InvalidArmorExeption>(() => rogue.Equip(armor));
        }

        [Fact]
        public void InvalidLevelExeption_Equip_ShouldThrowExeption()
        {
            Armor armor = new Armor("Mail", 3, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            Rogue rogue = new Rogue("James");

            Assert.Throws<InvalidLevelExeption>(() => rogue.Equip(armor));
        }

        [Fact]
        public void InvalidWeaponExeption_Equip_ShouldThrowExeption()
        {
            Weapons weapon = new Weapons("Staff", 1, Slot.Weapon, 1, WeaponType.Staff);
            Rogue rogue = new Rogue("James");

            Assert.Throws<InvalidWeaponExeption>(() => rogue.Equip(weapon));
        }

    }
}
