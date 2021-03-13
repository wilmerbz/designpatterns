using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StrategyPattern.Weapon
{
    public class GranadeLauncher : IWeapon
    {
        public void Activate()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("->");
                Thread.Sleep(100);
            }
            Console.WriteLine("BOOOOMMMMM!!!!");
        }
    }
}
