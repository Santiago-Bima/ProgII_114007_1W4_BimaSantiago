using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string pApellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int pDni
        {
            get { return dni; }
            set { dni = value; }
        }


        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
        }

        public Cliente(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            return nombre + " - " + apellido + " - " + dni;
        }
    }
}
