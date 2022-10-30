using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Movimiento
    {
        public double monto;
        public int tipo;


        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public Movimiento()
        {
            monto = 0;
            tipo = 0;
        }

        public Movimiento(double monto, int tipo)
        {
            this.monto = monto;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return monto + ", " + tipo;
        }
    }
}
