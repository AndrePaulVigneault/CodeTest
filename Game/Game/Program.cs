using Game.Races;
using Game.PhysicalWeapons;
using Game.MagicalWeapons;
using Game.Helmets;
using Game.Chests;
using Game.Arms;
using Game.Legs;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Giant TomRiddle = new Giant();
            TomRiddle.Weapon = new Book();
            TomRiddle.Helmet = new HelmetOfHealth();
            TomRiddle.Chest = new ChestOfHealth();
            TomRiddle.Legs = new LegsOfHealth();
            TomRiddle.Arms = new ArmsOfHealth();
            Console.WriteLine(TomRiddle.Stats());
            Console.ReadKey();
        }
    }
}
