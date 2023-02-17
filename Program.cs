using RPG_heroes.Heroes;
using RPG_heroes.Heroes.Classes;

namespace RPG_heroes
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            Mage SondreDude = new Mage("SondreDude");

            SondreDude.HeroDisplay();

      
        }

    }
}