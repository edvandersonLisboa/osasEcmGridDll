using AdicionarLinhaGrid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdicionarLinhaGrid
{
    class UpdateDao
    {
        public static void Update(int idVersao, string valorJson)
        {
            var conn = ConexaoDao.conexao();
            SqlCommand query;
            query = new SqlCommand($"UPDATE grid_dll SET resultado = '{valorJson}' WHERE id_vesao = {idVersao}", conn);
            query.ExecuteNonQuery();
            conn.Close();
        }
    }
}
