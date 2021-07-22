using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementation
{
    /// <summary>
    /// Lazy Optimized Implementation of the Singleton Pattern.
    /// </summary>
    public class LazyOptmizedSingleton
    {
        #region Singleton Implementation

        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static Lazy<LazyOptmizedSingleton> _instance = new Lazy<LazyOptmizedSingleton>(()=> new LazyOptmizedSingleton());


        /// <summary>
        /// Provides a Global access point to the singleton instance.
        /// </summary>
        public static LazyOptmizedSingleton Instance => _instance.Value;

        /// <summary>
        /// Private constructor. Instance of this class can only be created by itself/private members.
        /// </summary>
        private LazyOptmizedSingleton()
        {
            Console.WriteLine($"Creating {nameof(LazyOptmizedSingleton)} instance with expensive initialization...");

            Name = Guid.NewGuid().ToString();
            Thread.Sleep(5000);
        }

        #endregion


        // It is still a normal class with attributes, properties and methods.

        public string Name { get; set; }

        public void DoSomething(int param)
        {
            Console.WriteLine($"{nameof(LazyOptmizedSingleton)}: I'm instance {Name} for caller {param}");
        }


    }
}
