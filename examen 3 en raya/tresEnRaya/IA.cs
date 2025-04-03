using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresEnRaya
{
    public class IA
    {
        private int posicion = 0;
        private bool turno = true;

        public IA()
        {

        }

        public int escojerPosicion()
        {
            Random random = new Random();
            posicion = random.Next(8);
            return posicion;
        }

        public bool getTurno()
        {
            return turno;
        }
        public void setTurno(bool turno)
        {
            this.turno = turno;
        }
        public int getPosicion()
        {
            return posicion;
        }
    }
}
