using banco.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.AccesoDatos
{
    internal class DbHelperDao
    {
        private SqlConnection conn = new SqlConnection(Properties.Resources.cnnString);
        SqlCommand cmd = new SqlCommand();
        private static DbHelperDao instancia;

        public static DbHelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new DbHelperDao();
            return instancia;
        }

        public DataTable ConsultarDb(string consulta)
        {
            DataTable tabla = new DataTable();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            tabla.Load(cmd.ExecuteReader());
            conn.Close();
            return tabla;
        }

        public int EjecutarSP(string nombreSP, List<Parametros> lParametros)
        {

            try
            {
                int filasAfectadas;
                conn.Open();
                SqlCommand cmd = new SqlCommand(nombreSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                foreach (Parametros p in lParametros)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                conn.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
            }
        }

        public void eliminarDesdeCliente(int dni)
        {
            SqlCommand cmd = new SqlCommand("Sp_eliminarCliente", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.ExecuteNonQuery();
        }

        public void eliminarDesdeCuenta(int dni, int id)
        {
            SqlCommand cmd = new SqlCommand("Sp_eliminarCuentaYRelacionados", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@id_cliente", id);
            cmd.ExecuteNonQuery();
        }

        public void eliminarDesdeTransaccion(int dni)
        {
            SqlCommand cmd = new SqlCommand("Sp_eliminarMovimiento", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.ExecuteNonQuery();

            SqlCommand cmdT = new SqlCommand("Sp_eliminarTransaccionYRelacionados", conn);
            cmdT.CommandType = CommandType.StoredProcedure;
            cmdT.Parameters.Clear();
            cmdT.Parameters.AddWithValue("@dni", dni);
            cmdT.ExecuteNonQuery();
        }
        public bool EjecutarEliminarSP(string nombreSP, int dni, int id)
        {
            bool ok = true;
            try
            {
                conn.Open();

                if (nombreSP == "Sp_eliminarCliente")
                {
                    try
                    {
                        eliminarDesdeTransaccion(dni);
                        eliminarDesdeCuenta(dni, id);
                        eliminarDesdeCliente(dni);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
                    }

                }
                else
                {
                    try
                    {
                        eliminarDesdeTransaccion(dni);
                        eliminarDesdeCuenta(id, id);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
                    }
                }

                conn.Close();
                return ok;
            }
            catch (Exception ex)
            {
                throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
            }


        }

        public int ProximaTransaccion()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_PROXIMO_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();

            conn.Close();
            try
            {
                return (int)pOut.Value;
            }
            catch (Exception)
            {
                return 1;
            }


        }

        public bool ConfirmarTransaccion(Transaccion oTransaccion)
        {
            bool ok = true;

            SqlTransaction trs = null;

            try
            {
                conn.Open();
                trs = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MAESTRO", conn, trs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cuenta", oTransaccion.IdCuenta);
                cmd.Parameters.AddWithValue("@total", oTransaccion.CalcularTotal());

                SqlParameter pOut = new SqlParameter("@nro_transaccion", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int transaccionNro = (int)pOut.Value;
                int movimientoNro = 1;

                foreach (Movimiento item in oTransaccion.Movimiento)
                {
                    SqlCommand cmdMovimiento = new SqlCommand("SP_INSERTAR_DETALLE", conn, trs);
                    cmdMovimiento.CommandType = CommandType.StoredProcedure;
                    cmdMovimiento.Parameters.AddWithValue("@nro_transaccion", transaccionNro);
                    cmdMovimiento.Parameters.AddWithValue("@monto", item.Monto);
                    cmdMovimiento.Parameters.AddWithValue("@id_tipo", item.Tipo);
                    cmdMovimiento.ExecuteNonQuery();


                    movimientoNro++;

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
                if (conn.State == ConnectionState.Open) conn.Close();

            }

            return ok;

        }
    }
}
