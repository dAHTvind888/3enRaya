using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresEnRaya
{
    public class Jugador
    {
        private int posicionX = 0;
        private int posicionY = 0;
        private bool turno = true;

        public void escojerPosicion(int x, int y)
        {
            posicionX = x;
            posicionY = y;
        }

        public bool getTurno()
        {
            return turno;
        }
        public void setTurno(bool turno)
        {
            this.turno = turno;
        }
        public int getPosicionX()
        {
            return posicionX;
        }
        public int getPosicionY()
        {
            return posicionY;
        }

    }
}
