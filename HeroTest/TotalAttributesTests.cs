using RPG_heroes.Heroes.Attributes;
using RPG_heroes.Heroes.Classes;
using RPG_heroes.Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest
{

    public class TotalAttributesTests
    {

        [Fact]
        public void TotalAttributes_WithNoEquipment_ShouldBeCorrect()
        {
            Mage newHero = new Mage("Johnny");

            // Arange
            HeroAttributes expected = new HeroAttributes(1,1,8);

            //Act
            HeroAttributes actual = newHero.TotalAttributes();

            //Assert
            Assert.Equivalent(expected, actual);
        }

    }
    
}
