using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Datos.Interfaces
{
    internal interface ITransaccionDAO
    {
        DataTable ConsultarDB(string consulta);
        int EjecutarSP(string nombreSP, List<Parametros> lParametros);
        void eliminarDesdeCliente(int dni);
        void eliminarDesdeCuenta(int dni, int id);
        void eliminarDesdeTransaccion(int dni);
        bool EjecutarEliminarSP(string nombreSP, int dni, int id);
        int ProximaTransaccion();
        bool ConfirmarTransaccion(Transaccion oTransaccion);
    }
}
