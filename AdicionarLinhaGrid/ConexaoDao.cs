using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdicionarLinhaGrid
{
    class ConexaoDao
    {
        public static SqlConnection conexao()
        {

            string strConexao = "Server=BRSPEMEPDSK048\\SQLEXPRESS; Initial Catalog=db_ecmTeste;user id=sa;pwd=#lisboa1206";


            var conn = new SqlConnection(strConexao);
            conn.Open();


            return conn;

        }
    }
}
