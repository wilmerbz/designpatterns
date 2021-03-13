using StrategyPattern.Contex;
using StrategyPattern.Weapon;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var weapons = new List<IWeapon>() {
                new Knife(),
                new Gun(),
                new MachineGun(),
                new GranadeLauncher()
            };

            var character = new Character();

            foreach (IWeapon weapon in weapons)
            {
                character.Weapon = weapon;

                character.Attack();
            }

            Console.ReadKey();
        }
    }
}
