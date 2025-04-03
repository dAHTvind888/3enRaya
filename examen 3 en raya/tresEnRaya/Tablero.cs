using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresEnRaya
{
    public class Tablero
    {
        private string[] tablero = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };

        public string[] getTablero()
        {
            return tablero;
        }
        public void actualizarTableroIA(IA ia)
        {
            ia.getPosicion();
            while(tablero[ia.getPosicion()] == "O")
            {
                ia.escojerPosicion();
            }
            tablero[ia.getPosicion()] = "O";
        }

        public void actualizarTableroJugador(int x, int y)
        {
            if (x == y)
            {
                if (tablero[(x + y) * x] != "O")
                {
                    tablero[(x + y) * x] = "X";
                }
            }
            else if (x == 0)
            {
                if (tablero[y] != "O")
                {
                    tablero[y] = "X";
                }
            }
            else if (y == 0)
            {
                if (tablero[x * 3] != "O")
                {
                    tablero[x * 3] = "X";
                }
            }
            else if (x == 1 && y == 2)
            {
                if (tablero[5] != "O")
                {
                    tablero[5] = "X";
                }
            }
            else if (x == 2 && y == 1)
            {
                if (tablero[7] != "O")
                {
                    tablero[7] = "X";
                }
            }
        }
    }
}
