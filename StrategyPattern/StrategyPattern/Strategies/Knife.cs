using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Weapon
{
    public class Knife : IWeapon
    {
        public void Activate()
        {
            Console.WriteLine("zaz!");
        }
    }
}
