using StrategyPattern.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Contex
{
    public class Character
    {

        public IWeapon Weapon { get; set; }

        public void Attack()
        {
            Weapon.Activate();
        }

    }
}
