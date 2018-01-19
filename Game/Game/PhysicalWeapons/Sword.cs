using System;
using System.Collections.Generic;
using System.Text;

namespace Game.PhysicalWeapons
{
    class Sword:Weapon
    {
        public Sword()
        {
            base.PhysicalDamage = 200;
            base.Accuracy = 60;
        }
    }
}
