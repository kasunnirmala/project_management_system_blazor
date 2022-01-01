using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public class CompanyService:ICompanyService
    {
        private readonly HttpClient _httpClient;

        public CompanyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateCompany(Company company)
        {
            var result = await _httpClient.PostAsJsonAsync<Company>($"api/company", company);
            var isCompanySaved = await result.Content.ReadFromJsonAsync<bool>();
            return isCompanySaved;
        }

        public async Task<bool> DeleteCompany(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/company/{id}");
            var isCompanySaved = await result.Content.ReadFromJsonAsync<bool>();
            Console.WriteLine(isCompanySaved);
            return isCompanySaved;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _httpClient.GetFromJsonAsync<List<Company>>("api/company");
        }

        public async Task<Company> GetSingleCompany(int id)
        {
            return await _httpClient.GetFromJsonAsync<Company>($"api/company/{id}");
        }

        public async Task<bool> UpdateCompany(Company company)
        {
            var result = await _httpClient.PutAsJsonAsync<Company>($"api/company", company);
            var isCompanyUpdated = await result.Content.ReadFromJsonAsync<bool>();
            return isCompanyUpdated;
        }

       
    }
}
