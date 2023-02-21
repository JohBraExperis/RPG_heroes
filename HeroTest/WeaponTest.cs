using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest
{
    public class WeaponTest
    {

        [Fact]
        public void Weapon_Name_ShouldBeCorrect()
        {
            // Arange
            Weapons weapon = new Weapons("Axe", 1, Slot.Weapon, 1, WeaponType.Axe);
            string expected = "Axe";

            //Act
            string actual = weapon.Name;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_RequiredLevel_ShouldBeCorrect()
        {
            // Arange
            Weapons weapon = new Weapons("Axe", 1, Slot.Weapon, 1, WeaponType.Axe);
            int expected = 1;

            //Act
            int actual = weapon.RequiredLevel;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_Slot_ShouldBeCorrect()
        {
            // Arange
            Weapons weapon = new Weapons("Axe", 1, Slot.Weapon, 1, WeaponType.Axe);
            Slot expected = Slot.Weapon;

            //Act
            Slot actual = weapon.EquipmentSlot;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_WeaponDamage_ShouldBeCorrect()
        {
            // Arange
            Weapons weapon = new Weapons("Axe", 1, Slot.Weapon, 1, WeaponType.Axe);
            double expected = 1;

            //Act
            double actual = weapon.WeaponDamage;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_WeaponType_ShouldBeCorrect()
        {
            // Arange
            Weapons weapon = new Weapons("Axe", 1, Slot.Weapon, 1, WeaponType.Axe);
            WeaponType expected = WeaponType.Axe;

            //Act
            WeaponType actual = weapon.WeaponTypes;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
