using System;
using System.Collections.Generic;
using System.Text;

namespace Game.MagicalWeapons
{
    class MagicCards:Weapon
    {
        public MagicCards() {
            base.MagicalDamage = 100;
            base.Accuracy = 80;
        }
    }
}
