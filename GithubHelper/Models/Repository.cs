namespace GithubHelper.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public string HtmlUrl { get; set; }
        public string Description { get; set; }
        public bool Private { get; set; }
        public string DefaultBranch { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
