using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas.Dominio
{
    internal class Colas : ICollection
    {
        private List<object> lista;
        private int contador;

        public Colas()
        {
            contador = -1;
            lista = new List<object>();
        }
        public bool añadir(object elemento)
        {
            bool añadido = false;
            
            lista.Add(elemento);
            foreach (var e in lista)
            {
                if (e == elemento)
                {
                    añadido = true;
                    contador++;
                }
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
                e = lista[contador-contador];
                lista.RemoveAt(contador - contador);
                contador--;
            }
            return e;
        }

        public object primero()
        {
            object e = null;
            if (!estaVacia())
            {
                e = lista[contador - contador];
            }
            return e;
        }
}
}
