using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public class ProjectService:IProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _httpClient.GetFromJsonAsync<List<Project>>("api/project");
        }

        public async Task<Project> GetSingleProject(int id)
        {
            return await _httpClient.GetFromJsonAsync<Project>($"api/project/{id}");
        }
    }
}
