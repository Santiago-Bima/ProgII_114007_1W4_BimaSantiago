using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using RecetasSLN.Servicios.Interfaes;
using System.Data;

namespace RecetasSLN.Servicios.Implementaciones
{
    internal class Servicio : IServicio
    {
        private IRecetaDAO oDao;

        public Servicio()
        {
            oDao = new RecetaDAO();
        }
        public int ProximaReceta()
        {
            return oDao.ProximaReceta();
        }

        public DataTable ConsultarDB(string sp)
        {
            return oDao.ConsultarDB(sp);
        }

        public bool ConfirmarTransaccion(Receta oReceta)
        {
            return oDao.ConfirmarTransaccion(oReceta);
        }
    }
}
