using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementation
{
    /// <summary>
    /// Basic Implementation of the Singleton Pattern.
    /// </summary>
    public class BasicSingleton
    {
        #region Singleton Implementation

        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static BasicSingleton _instance;

        /// <summary>
        /// Provides a Global access point to the singleton instance.
        /// </summary>
        public static BasicSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BasicSingleton();
                }

                return _instance;

            }
        }


        /// <summary>
        /// Private constructor. Instance of this class can only be created by itself/private members.
        /// </summary>
        private BasicSingleton()
        {
            Console.WriteLine($"Creating {nameof(BasicSingleton)} instance with expensive initialization...");

            Name = Guid.NewGuid().ToString();
            Thread.Sleep(5000);
        }

        #endregion


        // It is still a normal class with attributes, properties and methods.

        public string Name { get; set; }

        public void DoSomething(int param)
        {
            Console.WriteLine($"{nameof(BasicSingleton)}: I'm instance {Name} for caller {param}");
        }


    }
}
