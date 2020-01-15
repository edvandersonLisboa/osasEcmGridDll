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

            string strConexao = "Server=WIN-5L8CHT3FIOH\\SQLEXPRESS2016; Initial Catalog=BD_TGESTIONA;user id=sa;pwd=osas@Admin";


            var conn = new SqlConnection(strConexao);
            conn.Open();


            return conn;

        }
    }
}
