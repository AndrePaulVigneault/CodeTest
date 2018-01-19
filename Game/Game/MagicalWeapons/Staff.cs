using System;
using System.Collections.Generic;
using System.Text;

namespace Game.MagicalWeapons
{
    class Staff:Weapon
    {
        public Staff()
        {
            base.MagicalDamage = 300;
            base.Accuracy = 40;
        }
    }
}
