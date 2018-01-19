using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Character
    {
        protected int PhysicalDamage { get; set; }
        protected int MagicalDamage { get; set; }
        protected int Accuracy { get; set; }
        protected int Health { get; set; }
        protected int PhysicalResistance { get; set; }
        protected int MagicalResistance { get; set; }
        public Weapon Weapon { get; set; }
        public Helmet Helmet { get; set; }
        public Chest Chest { get; set; }
        public Leg Legs { get; set; }
        public Arm Arms { get; set; }

        protected Character() {
            PhysicalDamage = 0;
            MagicalDamage = 0;
            Accuracy = 0;
            Health = 1000;
            PhysicalDamage = 0;
            MagicalResistance = 0;
        }
        public string Stats() {
            return $"Physical damage: {PhysicalDamage + Weapon.PhysicalDamage}\n" +
                $"Magical damage: {MagicalDamage + Weapon.MagicalDamage}\n" +
                $"Accuracy: {Accuracy + Weapon.Accuracy}\n" +
                $"Health: {Health + Helmet.Health + Chest.Health + Legs.Health + Arms.Health}\n" +
                $"Physical Resistance: {PhysicalResistance + Helmet.PhysicalResistance + Chest.PhysicalResistance + Legs.PhysicalResistance + Arms.PhysicalResistance}\n" +
                $"Magical Resistance: {MagicalResistance + Helmet.MagicalResistance + Chest.MagicalResistance + Legs.MagicalResistance + Arms.MagicalResistance}";

        }
    }
}
