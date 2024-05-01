using Newtonsoft.Json;

namespace GithubHelper.Models
{
    public class Repository
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
