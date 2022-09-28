using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        private int recetaNro;
        private string nombre;
        private int tipoReceta;
        private string cheff;

        public List<DetalleReceta> lDetalles;

        public int RecetaNro
        {
            get { return recetaNro; }
            set { recetaNro = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int TipoReceta
        {
            get { return tipoReceta; }
            set { tipoReceta = value; }
        }

        public string Cheff
        {
            get { return cheff; }
            set { cheff = value; }
        }

        public Receta()
        {
            RecetaNro = 0;
            Nombre = "";
            TipoReceta = -1;
            Cheff = "";
            lDetalles = new List<DetalleReceta>();
        }

        public Receta(int recetaNro, string nombre, int tipoReceta, string cheff, List<DetalleReceta> ldetalles)
        {
            this.recetaNro = recetaNro;
            this.nombre = nombre;
            this.tipoReceta = tipoReceta;
            this.cheff = cheff;
            this.lDetalles = ldetalles;
        }

        public void AgregarDetalle(DetalleReceta detalles)
        { lDetalles.Add(detalles); }

        public void QuitarDetalle(int posicion)
        {
            lDetalles.RemoveAt(posicion);
        }
    }
}
