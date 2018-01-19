using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Weapon
    {
        public int PhysicalDamage { get; protected set; }
        public int MagicalDamage { get; protected set; }
        public int Accuracy { get; protected set; }

        protected Weapon() {
            PhysicalDamage = 0;
            MagicalDamage = 0;
            Accuracy = 0;
        }
    }
}
