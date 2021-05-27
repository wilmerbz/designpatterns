using StrategyPattern.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Contex
{
    public abstract class Character
    {
        public abstract string Name { get; }

        public IWeapon Weapon { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacking!!");
            Weapon.Activate();
        }

    }
}
