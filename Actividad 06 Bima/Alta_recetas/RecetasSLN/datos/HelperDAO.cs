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

        public bool ConfirmarTransaccion(Receta receta)
        {
            bool ok = true;
            SqlTransaction trs = null;

            try
            {
                cnn.Open();
                trs = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("sp_insertar_receta", cnn, trs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);
                cmd.Parameters.AddWithValue("@nombre", receta.Nombre);
                cmd.Parameters.AddWithValue("@cheff", receta.Cheff);
                cmd.ExecuteNonQuery();

                foreach (DetalleReceta d in receta.lDetalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, trs);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_receta", receta.RecetaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", d.Ingrediente.IngredienteId);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", d.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
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
