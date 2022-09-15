using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas.Dominio
{
    internal class Pilas : ICollection
    {
        private object[] array;
        private int contador;

        public Pilas(int cantidad)
        {
            contador = -1;
            array = new object[cantidad];
        }
        public bool añadir(object elemento)
        {
            bool añadido = false;

            if (contador < array.Length)
            {
                array[++contador] = elemento;
                añadido = true;
            }

            return añadido;
        }

        public bool estaVacia()
        {
            return contador == -1;
        }

        public object extraer()
        {
            object e = null;

            if (!estaVacia())
            {
                e = array[contador];
                array[contador] = null;
                contador--;
            }
            return e;
        }

        public object primero()
        {
            object e = null;
            if (!estaVacia())
            {
                e = array[0];
            }
            return e;
        }
    }
}
