using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Weapon
{
    public class Gun : IWeapon
    {
        public void Activate()
        {
            Console.WriteLine("PA!");
        }
    }
}
