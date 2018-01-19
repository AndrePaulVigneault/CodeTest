using System;
using System.Collections.Generic;
using System.Text;

namespace Game.PhysicalWeapons
{
    class Spear:Weapon
    {
        public Spear()
        {
            base.PhysicalDamage = 300;
            base.Accuracy = 40;
        }
    }
}
