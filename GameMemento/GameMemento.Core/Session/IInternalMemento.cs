using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemento.Core.Session
{
    /// <summary>
    /// Interfaz amplia del Memento.
    /// </summary>
    internal interface IInternalMemento
    {
        /// <summary>
        /// Nivel.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// Puntaje.
        /// </summary>
        int Score { get; set; }

        /// <summary>
        /// Salud.
        /// </summary>
        int Health { get; set; }

    }
}
