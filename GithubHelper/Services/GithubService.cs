using GithubHelper.Models;
using Newtonsoft.Json;

namespace GithubHelper.Services
{
    public class GithubService
    {
        private readonly HttpClient _httpClient;

        public GithubService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("GitHubClient");
        }

        public async Task<IEnumerable<Repository>> GetPublicRepositoriesAsync(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}/repos");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var repositories = JsonConvert.DeserializeObject<IEnumerable<Repository>>(content);
            return repositories;
        }
    }
}
