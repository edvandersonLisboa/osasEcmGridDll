using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Grid
{
    class UpdateDao
    {
        public static void Update(int idVersao, string valorJson)
        {
            var conn = ConexaoDao.conexao();
            SqlCommand query;
            query = new SqlCommand($"UPDATE GRID_DLL SET resultado = '{valorJson}' WHERE id_versao = {idVersao}", conn);
            query.ExecuteNonQuery();
            conn.Close();
        }
    }
}
