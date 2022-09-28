using RecetasSLN.dominio;
using System;
using System.Data;
using System.Data.SqlClient;

namespace RecetasSLN.datos
{
    internal class HelperDAO : ConexionDB
    {
        private static HelperDAO instancia;

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null) instancia = new HelperDAO();
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
            SqlParameter pOut = new SqlParameter
            {
                ParameterName = "@Next",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
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
                    cmdReceta.Parameters.AddWithValue("@id_ingrediente", d.Ingrediente);
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
                cnn.Close();
            }

            return ok;
        }
    }
}
