using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegradorIbge.Dto;
using IntegradorIbge.Infra;
using Newtonsoft.Json;
using System.IO;
using IntegradorIbge.Infra.Dto;

namespace IntegradorIbge.Servicos
{
    public class BuscadorMunicipio : IBuscadorMunicipio
    {
        public List<MunicipioDto> BuscarMunicipiosDaUf(int uf)
        {
            var resposta = new ConexaoHttpClient().GetResponse(string.Format("https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios", uf));

            if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var content = resposta.Content.ReadAsStringAsync();
            File.WriteAllText("c:/temp/teste.txt", content.Result);
            return JsonConvert.DeserializeObject<List<MunicipioDto>>(content.Result);
        }

        public string BuscarMunicipiosDaUfJson(int uf)
        {
            var municipios = BuscarMunicipiosDaUf(uf);
            return municipios != null && municipios.Any()
                ? JsonConvert.SerializeObject(municipios)
                : null;
        }
    }
}
