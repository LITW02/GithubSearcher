using Newtonsoft.Json;

namespace GithubAPI.API
{
    public class GithubRepo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        [JsonProperty("stargazers_count")]
        public int Stars { get; set; }
    }
}