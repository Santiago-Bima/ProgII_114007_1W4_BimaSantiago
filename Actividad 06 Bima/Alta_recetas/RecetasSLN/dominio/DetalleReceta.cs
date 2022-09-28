using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        public Ingrediente ingrediente;
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DetalleReceta()
        {
            ingrediente = new Ingrediente();
            cantidad = 0;
        }

        public DetalleReceta(Ingrediente ingrediente, int cantidad)
        {
            this.ingrediente = ingrediente;
            this.cantidad = cantidad;
        }
    }
}
