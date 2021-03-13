using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemento.Core.Session
{
    /// <summary>
    /// Clase Memento, representa el estado del juego en un momento determinado.
    /// </summary>
    internal class CheckpointMemento: IPublicMemento, IInternalMemento
    {
        /// <summary>
        /// Nivel.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Puntaje.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Salud.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Crea una nueva instancia de la clase Memento.
        /// </summary>
        public CheckpointMemento()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase memento, con los valor dados.
        /// </summary>
        /// <param name="level">Nivel.</param>
        /// <param name="score">Puntaje.</param>
        /// <param name="health">Salud.</param>
        public CheckpointMemento(int level, int score, int health)
        {
            this.Level = level;
            this.Score = score;
            this.Health = health;
        }
    }
}
