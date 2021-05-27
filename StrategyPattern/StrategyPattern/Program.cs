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
                new Gun(),
                new MachineGun(),
                new GranadeLauncher(),
                new Knife()
            };

            
            
            Character character = null;

            // Livskov principle
            character = new Knight();
            //character = new Troll();

            //Depend on abstractions, not concrete implementations.
            //Interchangeable algorithms.

            foreach (IWeapon weapon in weapons)
            {
                character.Weapon = weapon;

                character.Attack();
            }

            Console.ReadKey();
        }
    }
}
