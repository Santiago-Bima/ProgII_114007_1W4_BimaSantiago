using System.Data;
using System.Data.SqlClient;

namespace RecetasSLN.datos
{
    internal class ConexionDB
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=SANTIPC\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True");


        public SqlCommand Conectar(string sp)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
