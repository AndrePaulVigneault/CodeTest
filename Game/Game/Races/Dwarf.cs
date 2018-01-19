using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Races
{
    class Dwarf:Character
    {
        public Dwarf()
        {
            base.PhysicalResistance += 30;
        }
    }
}
