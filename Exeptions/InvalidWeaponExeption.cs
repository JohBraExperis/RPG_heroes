using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Exeptions
{
    internal class InvalidWeaponExeption : Exception
    {

        public class InvalidArmorExeption : Exception
        {

            public InvalidArmorExeption()
            {
            }

            public InvalidArmorExeption(string message)
                : base(message)
            {
            }

            public override string Message => "you cannot wear that weapon young prince";

        }


    }
}
