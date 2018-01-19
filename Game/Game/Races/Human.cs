using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Races
{
    class Human:Character
    {
        public Human() {
            base.PhysicalDamage += 100;
            base.MagicalDamage += 100;
        }
    }
}
