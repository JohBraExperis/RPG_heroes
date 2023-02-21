using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Items;

namespace HeroTest

{
    public class ArmorTest
    {

        [Fact]
        public void Armor_Name_ShouldBeCorrect()
        {
            // Arange
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            string expected = "Test";

            //Act
            string actual = armor.Name;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_RequiredLevel_ShouldBeCorrect()
        {
            // Arrange
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            int expected = 1;

            //Act
            int actual = armor.RequiredLevel;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_Slot_ShouldBeCorrect()
        {
            // Arrange
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            Slot expected = Slot.Body;

            //Act
            Slot actual = armor.EquipmentSlot;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_ArmorType_ShouldBeCorrect()
        {
            // Arrange
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            ArmorType expected = ArmorType.Mail;

            //Act
            ArmorType actual = armor.ArmorTypes;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_ArmorAttribute_ShouldBeCorrect()
        {
            // Arrange
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));
            HeroAttributes expected = new(2, 2, 2);

            //Act
            HeroAttributes actual = armor.ArmorAttribute;

            //Assert
            Assert.Equivalent(expected, actual);
        }

    }
}