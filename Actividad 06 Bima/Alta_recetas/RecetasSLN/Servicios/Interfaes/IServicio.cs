using RecetasSLN.dominio;
using System.Data;

namespace RecetasSLN.Servicios.Interfaes
{
    internal interface IServicio
    {
        int ProximaReceta();
        DataTable ConsultarDB(string sp);
        bool ConfirmarTransaccion(Receta oReceta);
    }
}
