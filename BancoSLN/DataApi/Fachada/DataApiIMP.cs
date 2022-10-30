using DataApi.Datos;
using DataApi.Datos.Implementaciones;
using DataApi.Datos.Interfaces;
using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataApi.Fachada
{
    public class DataApiIMP : IDataApi
    {
        private ITransaccionDAO dao;

        public DataApiIMP()
        {
            dao = new TransaccionDAO();
        }

        public DataTable GetCuentas()
        {
            return dao.ConsultarDB("select * from cuentas");
        }

        public bool SaveTransaccion(Transaccion transaccion)
        {
            return dao.ConfirmarTransaccion(transaccion);
        }
    }
}
