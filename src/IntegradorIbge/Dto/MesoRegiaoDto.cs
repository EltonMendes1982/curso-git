using Newtonsoft.Json;

namespace IntegradorIbge.Dto
{
    public class MesoRegiaoDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("UF")]
        public UfDto Uf { get; set; }
    }
}
