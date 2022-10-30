using DataApi.Datos.Interfaces;
using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Datos.Implementaciones
{
    internal class TransaccionDAO : ITransaccionDAO
    {
        public bool ConfirmarTransaccion(Transaccion oTransaccion)
        {
            return DbHelperDao.ObtenerInstancia().ConfirmarTransaccion(oTransaccion);
        }

        public DataTable ConsultarDB(string consulta)
        {
            return DbHelperDao.ObtenerInstancia().ConsultarDb(consulta);
        }

        public bool EjecutarEliminarSP(string nombreSP, int dni, int id)
        {
            return DbHelperDao.ObtenerInstancia().EjecutarEliminarSP(nombreSP, dni, id);
        }

        public int EjecutarSP(string nombreSP, List<Parametros> lParametros)
        {
            return DbHelperDao.ObtenerInstancia().EjecutarSP(nombreSP, lParametros);
        }

        public void eliminarDesdeCliente(int dni)
        {
            throw new NotImplementedException();
        }

        public void eliminarDesdeCuenta(int dni, int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarDesdeTransaccion(int dni)
        {
            throw new NotImplementedException();
        }

        public int ProximaTransaccion()
        {
            return DbHelperDao.ObtenerInstancia().ProximaTransaccion();
        }
    }
}
