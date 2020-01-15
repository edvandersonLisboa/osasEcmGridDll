using System;
using System.Data.SqlClient;


namespace Grid
{
    class ListarGridDao
    {
        public static Grid GridLista(int idversao)
        {
            var conn = ConexaoDao.conexao();
            var query = new SqlCommand("select * from GRID_DLL where id_versao = @ID_VERSAO", conn);
            query.Parameters.AddWithValue("@ID_VERSAO", idversao);

            SqlDataReader dr = query.ExecuteReader();
            Grid retorno = null;


                while (dr.Read())
                {
                retorno =  new Grid(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), dr[2].ToString());

                }

                dr.Close();
                conn.Close();


            return retorno; 

        }
    }
}
