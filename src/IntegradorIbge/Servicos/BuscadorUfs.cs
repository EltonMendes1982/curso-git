using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegradorIbge.Dto;
using IntegradorIbge.Infra;
using Newtonsoft.Json;
using IntegradorIbge.Infra.Dto;

namespace IntegradorIbge.Servicos
{
    public class BuscadorUfs : IBuscadorUfs
    {
        public List<UfDto> BuscarUfs()
        {
            var resposta = new ConexaoHttpClient().GetResponse("https://servicodados.ibge.gov.br/api/v1/localidades/estados");

            if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var content = resposta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UfDto>>(content.Result);
        }
    }
}
