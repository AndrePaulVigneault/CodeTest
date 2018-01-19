using System;
using System.Collections.Generic;
using System.Text;

namespace Game.MagicalWeapons
{
    class Scepter:Weapon
    {
        public Scepter()
        {
            base.MagicalDamage = 200;
            base.Accuracy = 60;
        }
    }
}
