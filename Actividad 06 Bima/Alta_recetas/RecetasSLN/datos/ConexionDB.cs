using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RecetasSLN.datos
{
    internal class ConexionDB
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NJSKJPR\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True");
        

        public SqlCommand Conectar(string sp)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public void Desconectar()
        {
            cnn.Close();
        }
    }
}
