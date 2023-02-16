using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Exeptions
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

        public override string Message => "you cannot wear that armor young prince";

    }
}
