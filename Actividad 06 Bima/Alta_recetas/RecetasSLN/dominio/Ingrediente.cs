using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Ingrediente
    {
        private int ingredienteId;
        private string nombre;
        private int unidad;

        public int IngredienteId
        {
            get { return ingredienteId; }
            set { ingredienteId = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public Ingrediente()
        {
            ingredienteId = 0;
            nombre = "";
            unidad = 0;
        }

        public Ingrediente(int igredienteId, string nombre, int unidad)
        {
            this.ingredienteId = igredienteId;
            this.nombre = nombre;
            this.unidad = unidad;
        }
    }
}
