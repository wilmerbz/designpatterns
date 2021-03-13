using GameMemento.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameMemento
{
    class Game
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine($"> Iniciando Juego :O");
            Thread.Sleep(2500);

            player.Level = 1;
            player.Score = 500;
            player.Health = 100;

            Console.WriteLine($"\n[OK] > Nivel 1 completado :)\n{player}");
            Thread.Sleep(2500);

            //Cuando el jugador completa un nivel, crear un checkpoint para ese nivel.
            GameMemory gameMemory = GameMemory.Instance;
            IPublicMemento memento = player.CreateCheckpoint();
            gameMemory.SaveGameMarker(memento);

            player.Level = 2;
            player.Score = 250;
            player.Health = 50;

            Console.WriteLine($"\n[OK] > Nivel 2 completado :P \n{player}");
            Thread.Sleep(2500);

            //Guardar resultado de nivel 2.
            memento = player.CreateCheckpoint();
            gameMemory.SaveGameMarker(memento);

            player.Level = 3;
            player.Score = 100;
            player.Health = 0;

            Console.WriteLine($"\n[X] > Nivel 3 NO completado :(\n{player}");
            Thread.Sleep(2500);

            IPublicMemento lastMemento = gameMemory.GetLastGameMarker();
            player.RestoreCheckpoint(lastMemento);
            Console.WriteLine($"\n[OK]> Nivel 2 Restaurado :D\n{player}");

            Thread.Sleep(2500);

            IPublicMemento firstMemento = gameMemory.GetGameMarker(0);
            player.RestoreCheckpoint(firstMemento);
            Console.WriteLine($"\n[OK]> Nivel 1 Restaurado :/\n{player}");

            //No puede utilizar la interfaz interna.
            //memento.Score = 99999;
            //IInternalGameMemento internalMemento = memento as IInternalGameMemento;
            //internalMemento.Level = 99999;

            Console.ReadKey();


        }
    }
}
