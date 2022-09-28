using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {

        public List<DetalleReceta> lDetalles { get; set; }

        public int RecetaNro { get; set; }
        public string Nombre { get; set; }
        public int TipoReceta {get; set; }
        public string Cheff { get; set; }

        public Receta()
        {
            lDetalles = new List<DetalleReceta>();
        }

        public void AgregarDetalle(DetalleReceta detalles)
        { lDetalles.Add(detalles); }

        public void QuitarDetalle(int posicion)
        {
            lDetalles.RemoveAt(posicion);
        }
    }
}
