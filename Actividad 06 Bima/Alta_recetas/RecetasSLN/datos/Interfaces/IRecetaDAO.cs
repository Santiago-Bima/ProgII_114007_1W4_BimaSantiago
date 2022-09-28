using RecetasSLN.dominio;
using System.Data;

namespace RecetasSLN.datos.Interfaces
{
    internal interface IRecetaDAO
    {
        int ProximaReceta();
        DataTable ConsultarDB(string sp);
        bool ConfirmarTransaccion(Receta oReceta);
    }
}
