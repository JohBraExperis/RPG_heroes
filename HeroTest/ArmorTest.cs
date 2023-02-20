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
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));

            int expected = 1;
            int actual = armor.RequiredLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_Slot_ShouldBeCorrect()
        {
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));

            Slot expected = Slot.Body;
            Slot actual = armor.EquipmentSlot;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_ArmorType_ShouldBeCorrect()
        {
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));

            ArmorType expected = ArmorType.Mail;
            ArmorType actual = armor.ArmorTypes;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_ArmorAttribute_ShouldBeCorrect()
        {
            Armor armor = new Armor("Test", 1, Slot.Body, ArmorType.Mail, new(2, 2, 2));

            HeroAttributes expected = new(2, 2, 2);
            HeroAttributes actual = armor.ArmorAttribute;

            Assert.Equivalent(expected, actual);
        }

    }
}