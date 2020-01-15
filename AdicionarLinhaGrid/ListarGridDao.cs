using AdicionarLinhaGrid;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace AdicionarLinhaGrid
{
    class ListarGridDao
    {
        public static List<Grid> listaGrid(int idversao)
        {
            var conn = ConexaoDao.conexao();
            var query = new SqlCommand("select * from grid_dll where id_vesao = @ID_VERSAO", conn);
            query.Parameters.AddWithValue("@ID_VERSAO", idversao);

            SqlDataReader dr = query.ExecuteReader();
            var grid = new List<Grid>();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    grid.Add(new Grid(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), new JavaScriptSerializer().Serialize(dr[2])));

                 }

                dr.Close();
                conn.Close();

                return grid;
            }
            else
            {

                return grid;
            }

        }
    }
}
