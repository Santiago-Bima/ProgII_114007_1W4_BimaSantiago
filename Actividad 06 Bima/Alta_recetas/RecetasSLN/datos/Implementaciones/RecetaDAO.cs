using System.Data;
using System.Runtime.Remoting.Messaging;
using RecetasSLN.datos;
using RecetasSLN.dominio;

namespace RecetasSLN.datos.Interfaces
{
    internal class RecetaDAO : IRecetaDAO
    {
        public int ProximaReceta() {
            return HelperDAO.ObtenerInstancia().ProximaReceta();
        }

        public DataTable ConsultarDB(string sp)
        {
            return HelperDAO.ObtenerInstancia().ConsultarDB(sp);
        }

        public bool ConfirmarTransaccion(Receta oReceta)
        {
            return HelperDAO.ObtenerInstancia().ConfirmarTransaccion(oReceta);
        }
    }
}