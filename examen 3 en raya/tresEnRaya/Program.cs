using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresEnRaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            Jugador jugador = new Jugador();
            IA ia = new IA();
            bool gameOver = false;
            int aux = 0;

            while (gameOver == false)
            {
                Console.WriteLine("Escojer un valor desde 0 - 2 para la fila");
                int x_Jugador = int.Parse(Console.ReadLine());
                Console.WriteLine("Escojer un valor desde 0 - 2 para la columna");
                int y_Jugador = int.Parse(Console.ReadLine());
                
                jugador.escojerPosicion(x_Jugador, y_Jugador);

                tablero.actualizarTableroJugador(jugador.getPosicionX(), jugador.getPosicionY());
                tablero.actualizarTableroIA(ia);
                jugador.escojerPosicion(0, 0);

                Console.WriteLine("Tablero: ");

                for(int i = 0; i < tablero.getTablero().Length; i++)
                {
                    if(aux == 3)
                    {
                        Console.WriteLine();
                        aux = 0;
                    }
                    Console.Write(tablero.getTablero()[i]);
                    aux++;
                }
                Console.WriteLine();
            }
                



            


            /*
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int aux = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(aux == 3)
                {
                    Console.WriteLine();
                    aux = 0;
                }
                Console.Write(arr[i]);
                aux++;
            }
            */
        }
    }
}
