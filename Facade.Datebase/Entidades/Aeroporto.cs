using Newtonsoft.Json;

namespace Facade.Datebase.Entidades
{
    public class Aeroporto
    {
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }
    }
}
