using System;
using System.Data.SqlClient;

namespace Grid
{
    public class AdicinarLinhaGridDao
    {
        public static void AdicionarLinhaGrid(int idversao, string valorJson)
        {

            var lista = ListarGridDao.GridLista(idversao);

            if (ListarGridDao.GridLista(idversao) == null)
            {
                var conn = ConexaoDao.conexao();
                SqlCommand query;

                query = new SqlCommand($"INSERT INTO GRID_DLL (id_versao, resultado) VALUES ({idversao},'{valorJson}')", conn);
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
