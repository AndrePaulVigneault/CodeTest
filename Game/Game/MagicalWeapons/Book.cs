using System;
using System.Collections.Generic;
using System.Text;

namespace Game.MagicalWeapons
{
    class Book:Weapon
    {
        public Book()
        {
            base.MagicalDamage = 400;
            base.Accuracy = 20;
        }
    }
}
