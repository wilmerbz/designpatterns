using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemento.Session
{
    /// <summary>
    /// Clase Originator (Creador).
    /// </summary>
    public class Player
    {
        #region State
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

        #endregion

        #region Other Attributes

        private int lives = 3;

        /// <summary>
        /// Numero de vidas .
        /// </summary>
        public int Lives
        {
            get
            {
                return lives;
            }
            private set
            {
                lives = value;
            }
        }

        #endregion

        /// <summary>
        /// Crea una instancia de Memento, con el estado actual del jugador.
        /// </summary>
        /// <returns>Memento creado, representado por su interfaz pública.</returns>
        public IPublicMemento CreateCheckpoint()
        {
            IPublicMemento memento = new CheckpointMemento
            {
                Level = this.Level,
                Score = this.Score,
                Health = this.Health
            };

            return memento;
        }

        /// <summary>
        /// Restaura el estado del jugador utilizando el estado del memento.
        /// </summary>
        /// <returns>Memento que contiene el estado a restaurar.</returns>
        public void RestoreCheckpoint(IPublicMemento memento)
        {
            if (memento == null)
            {
                throw new ArgumentException("Memento no debe ser nulo.");
            }

            IInternalMemento internalMemento = memento as IInternalMemento;
            if (internalMemento == null)
            {
                throw new InvalidCastException("Memento inválido.");
            }

            this.Level = internalMemento.Level;
            this.Score = internalMemento.Score;
            this.Health = internalMemento.Health;
            this.Lives--;
        }


        public override string ToString()
        {
            return $"Nivel: {this.Level}\nPuntaje: {this.Score}\nSalud: {this.Health}%\nVidas: {this.Lives}";
        }

    }
}
