using RPG_heroes.Heroes;
using RPG_heroes.Heroes.Classes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest
{



}
/* public class MageTest
{

    [Fact]
    public void Mage_States_ShouldBeCorrect() {

            // Arrange
            Mage mage = new Mage("Conan");
            double expectedDamage;

            // Act 1: Calculate damage if no weapon is equipped
            expectedDamage = 1 * (1 + (5 / 100));
            double actualDamage = mage.DamageAttribute;
            Assert.Equal(expectedDamage, actualDamage);

            // Act 2: Calculate damage with valid weapon equipped
            Hero.Equip(new Mage("Axe", 1, Slot.Weapon, 2, WeaponType.Staff));
            expectedDamage = 2 * (1 + (5 / 100));
            actualDamage = mage.Dama();
            Assert.Equal(expectedDamage, actualDamage);

            // Act 3: Calculate damage with valid weapon and armor equipped
            mage.EquipArmor(new Armor("Plate Body", 1, Slot.Body, ArmorType.Plate));
            expectedDamage = 2 * (1 + ((5 + 1) / 100));
            actualDamage = mage.CalculateDamage();
            Assert.Equal(expectedDamage, actualDamage);
        }
    }


}

}
*/
