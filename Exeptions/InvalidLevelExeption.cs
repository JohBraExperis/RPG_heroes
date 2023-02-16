using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Exeptions
{

        public class InvalidLevelExeption : Exception
        {

            public InvalidLevelExeption()
            {
            }

            public InvalidLevelExeption(string message)
                : base(message)
            {
            }

            public override string Message => "your level is not high enough young prince";

        }

    }
