using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Cliente
    {
        public string nombre;
        public string apellido;
        public int dni;

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
            nombre = "";
            apellido = "";
            dni = 0;
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
