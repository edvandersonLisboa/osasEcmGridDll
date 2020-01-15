using GO.ECM.ScriptDotNet.Atributos;
using GO.ECM.ScriptDotNet.ProdutoEspecifico;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    [ClasseScript]
    class ManipulacaoGrid : ScriptEcm
    {

        [MetodoScript]
        public void adicionarGrid()
        {
            var array = base.RetornaContexto();
            var valorJson = base.contexto.InformacoesExtra[0].Valor;
            var idversao = base.contexto.InformacoesExtra[0].Chave;
            AdicinarLinhaGridDao.AdicionarLinhaGrid(Convert.ToInt32(idversao), Convert.ToString(valorJson));
            base.contexto.Retorno.Objeto = valorJson;
        }

        [MetodoScript]
        public void ListaGrid()
        {
            var parametros = base.contexto.InformacoesExtra;
            //  var idVersao = parametros?.Find(p => p.Chave == "id_versao")?.Valor.ToString();
            var array = base.RetornaContexto();


            var idversao = base.contexto.InformacoesExtra[0].Chave;




            var retornoTela = ListarGridDao.GridLista(Convert.ToInt32(idversao));


            var retornoGambiarra = JsonConvert.SerializeObject(retornoTela);


            base.contexto.Retorno.Objeto = retornoGambiarra;
          
        }

    }

   
}
