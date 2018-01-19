using System;
using System.Collections.Generic;
using System.Text;

namespace Game.PhysicalWeapons
{
    class Axe:Weapon
    {
        public Axe()
        {
            base.PhysicalDamage = 400;
            base.Accuracy = 20;
        }
    }
}
