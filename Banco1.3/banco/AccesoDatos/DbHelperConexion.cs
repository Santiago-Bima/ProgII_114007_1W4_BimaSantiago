using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using banco.Dominio;
    
namespace banco
{
    internal class DbHelperConexion
    {
        private SqlConnection conn = new SqlConnection(Properties.Resources.cnnString);
        SqlCommand cmd = new SqlCommand();

        protected void conectar()
        {
            conn.Open();
            cmd.Connection = conn;
        }

        protected void Desconectar()
        {
            conn.Close();
        }
    }
}
