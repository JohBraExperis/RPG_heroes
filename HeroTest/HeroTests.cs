using RPG_heroes.Heroes;
using RPG_heroes.Heroes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest
{
    public class HeroTests
    {
        [Fact]
        public void CreateHero_name_ShouldBeCorrect() {

            Mage newHero = new Mage("Johnny");

            string expected = "Johnny";
            string actual = newHero.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_Level_ShouldBeCorrect()
        {
            Mage newHero = new Mage("Johnny");
            newHero.LevelUp();

            int expected = 2;
            int actual = newHero.Level;

            Assert.Equal(expected, actual);
        }
    }
}
