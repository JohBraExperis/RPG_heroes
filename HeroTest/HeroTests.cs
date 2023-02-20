using RPG_heroes.Heroes;
using RPG_heroes.Heroes.Classes;

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
