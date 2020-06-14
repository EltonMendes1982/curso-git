using Newtonsoft.Json;

namespace IntegradorIbge.Dto
{
    public class RegiaoDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
    }
}