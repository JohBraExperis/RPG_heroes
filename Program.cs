using RPG_heroes.Heroes;
using RPG_heroes.Heroes.Classes;
using RPG_heroes.Heroes.Items;

namespace RPG_heroes
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            Mage SondreDude = new Mage("SondreDude");
            Weapons weapon = new Weapons("test", 0, Slot.Weapon, 1, WeaponType.Staff);

            SondreDude.Equip(weapon);

            SondreDude.HeroDisplay();

      
        }

    }
}