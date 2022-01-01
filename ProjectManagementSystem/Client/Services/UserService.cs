using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public class UserService:IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("api/user");
        }

        public async Task<User> GetSingleUser(int id)
        {
            return await _httpClient.GetFromJsonAsync<User>($"api/user/{id}");
        }
    }
}
