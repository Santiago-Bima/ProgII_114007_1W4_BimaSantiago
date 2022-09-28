using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class RecetaDao : ConexionDB
    {
        private static RecetaDao instancia;
        
        public static RecetaDao ObtenerInstancia()
        {
            if(instancia == null) instancia = new RecetaDao();
            return instancia;
        }
        
        public DataTable ConsultarDB(string sp)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = Conectar(sp);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public int ProximaReceta()
        {
            SqlCommand cmd = Conectar("SP_Proximo_ID");
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@Next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            Desconectar();
            try
            {
                return (int)pOut.Value;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public bool ConfirmarTransaccion(Receta oReceta)
        {
            bool ok = true;
            SqlTransaction trs = null;

            try
            {
                SqlCommand cmd = Conectar("SP_insertar_receta");
                cmd.Parameters.AddWithValue("@tipo_receta", oReceta.TipoReceta);
                cmd.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                cmd.Parameters.AddWithValue("@cheff", oReceta.Cheff);
                cmd.ExecuteNonQuery();
                int recetaNumero = ProximaReceta() + 1;

                foreach (DetalleReceta d in oReceta.lDetalles)
                {
                    SqlCommand cmdReceta = Conectar("sp_insertar_detalles");
                    cmdReceta.Parameters.AddWithValue("@id_receta", recetaNumero);
                    cmdReceta.Parameters.AddWithValue("@id_ingrediente", d.ingrediente);
                    cmdReceta.Parameters.AddWithValue("@cantidad", d.Cantidad);
                    cmdReceta.ExecuteNonQuery();
                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                ok = false;
            }

            finally
            {
                Desconectar();
            }

            return ok;
        }
    }
}
