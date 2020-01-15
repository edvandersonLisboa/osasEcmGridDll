using System;
using System.Data.SqlClient;

namespace AdicionarLinhaGrid
{
    public class AdicinarLinhaGridDao
    {
        public static void AdicionarLinhaGrid(int idversao, string valorJson)
        {
           


            if (ListarGridDao.listaGrid(idversao).Count < 1)
            {
                var conn = ConexaoDao.conexao();
                SqlCommand query;

                query = new SqlCommand($"INSERT INTO grid_dll (id_vesao, resultado) VALUES ({idversao},'{valorJson}')", conn);
                query.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                UpdateDao.Update(idversao, valorJson);
            }



           
        }
    }
}
