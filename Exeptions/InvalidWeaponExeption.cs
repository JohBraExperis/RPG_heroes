using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Exeptions
{
    public class InvalidWeaponExeption : Exception
    {

            public InvalidWeaponExeption()
            {
            }

            public InvalidWeaponExeption(string message)
                : base(message)
            {
            }

            public override string Message => "you cannot wear that weapon young prince";

        }

   }
