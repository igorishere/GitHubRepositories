using Newtonsoft.Json;
using System.Collections.Generic;

namespace GitHubRepositories.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RepositorioModel
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("html_url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("languages_url")]
        public string Languages_url { get; set; }

        public List<LinguagemModel> listaDeRepositorios { get; set; }
    }
}
