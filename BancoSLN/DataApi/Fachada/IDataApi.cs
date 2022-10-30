using DataApi.Datos;
using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Fachada
{
    public interface IDataApi
    {
        public DataTable GetCuentas();
        public bool SaveTransaccion(Transaccion transaccion);
    }
}
