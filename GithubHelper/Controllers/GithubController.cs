using GithubHelper.Services;
using Microsoft.AspNetCore.Mvc;

namespace GithubHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubController : ControllerBase
    {
        private readonly GithubService _gitHubService;

        public GitHubController(GithubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet("users/{username}/repos")]
        public async Task<IActionResult> GetPublicRepositories(string username)
        {
            var repos = await _gitHubService.GetPublicRepositoriesAsync(username);
            return Ok(repos);
        }
    }
}
