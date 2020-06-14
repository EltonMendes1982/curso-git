using Newtonsoft.Json;

namespace IntegradorIbge.Dto
{
    public class MicroRegiaoDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("mesorregiao")]
        public MesoRegiaoDto MesoRegiao { get; set; }
    }
}