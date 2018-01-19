using System;
using System.Collections.Generic;
using System.Text;

namespace Game.PhysicalWeapons
{
    class Daggers:Weapon
    {
        public Daggers() {
            base.PhysicalDamage = 100;
            base.Accuracy = 80;
        }
    }
}
