using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Grid
{
    class ConexaoDao
    {
        public static SqlConnection conexao()
        {

            string strConexao = "Server=OSASHOMOLOG; Initial Catalog=DB_TGESTIONA;user id=sa;pwd=osasAdminHomologa";


            var conn = new SqlConnection(strConexao);
            conn.Open();


            return conn;

        }
    }
}
