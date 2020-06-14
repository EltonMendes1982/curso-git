using Newtonsoft.Json;

namespace IntegradorIbge.Dto
{
    public class MunicipioDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("microrregiao")]
        public MicroRegiaoDto MicroRegiao { get; set; }
    }
}