using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementation
{
    /// <summary>
    /// Locked Implementation of the Singleton Pattern for Multithreaded environments.
    /// </summary>
    public class LockedSingleton
    {
        #region Singleton Implementation

        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static LockedSingleton _instance;

        private static object _lock = new();

        /// <summary>
        /// Provides a Global access point to the singleton instance.
        /// </summary>
        public static LockedSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LockedSingleton();
                        }
                    }
                }

                return _instance;

            }
        }


        /// <summary>
        /// Private constructor. Instance of this class can only be created by itself/private members.
        /// </summary>
        private LockedSingleton()
        {
            Console.WriteLine($"Creating {nameof(LockedSingleton)} instance with expensive initialization...");

            Name = Guid.NewGuid().ToString();
            Thread.Sleep(5000);
        }

        #endregion


        // It is still a normal class with attributes, properties and methods.

        public string Name { get; set; }

        public void DoSomething(int param)
        {
            Console.WriteLine($"{nameof(LockedSingleton)}: I'm instance {Name} for caller {param}");
        }


    }
}
