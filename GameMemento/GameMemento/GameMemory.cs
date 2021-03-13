using GameMemento.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemento
{
    /// <summary>
    /// Caretaker - Es responsable de guardar el memento en un lugar seguro.
    /// </summary>
    public class GameMemory
    {
        #region Singleton
        private static  Lazy<GameMemory> _lazyInitializer = new Lazy<GameMemory>(()=>  new GameMemory());

        /// <summary>
        /// Singleton instance of the Caretaker.
        /// </summary>
        public static GameMemory Instance => _lazyInitializer.Value;

        /// <summary>
        /// Private constructor for the Caretaker singleton
        /// </summary>
        private GameMemory() {
            GameMarkers = new List<IPublicMemento>();
        }
        #endregion

        /// <summary>
        /// Mementos guardados. Utiliza interfaz publica, pues nunca examina los contenidos del memento, ni opera sobre ellos.
        /// </summary>
        private List<IPublicMemento> GameMarkers { get; set; }

        /// <summary>
        /// Guarda el memento en la colección.
        /// </summary>
        /// <param name="gameMarker">Memento a guardar.</param>
        public void SaveGameMarker(IPublicMemento gameMarker)
        {
            GameMarkers.Add(gameMarker);
        }

        /// <summary>
        /// Obtiene el último memento guardado.
        /// </summary>
        /// <returns>Memento.</returns>
        public IPublicMemento GetLastGameMarker()
        {
            return GameMarkers.Last();
        }

        /// <summary>
        /// Obtiene el memento en el índice dado.
        /// </summary>
        /// <param name="index">Índice del memento.</param>
        /// <returns>Memento.</returns>
        public IPublicMemento GetGameMarker(int index)
        {
            return GameMarkers[index];
        }
    }
}
