using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StrategyPattern.Weapon
{
    public class MachineGun : IWeapon
    {
        public void Activate()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write("Pra!");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}
