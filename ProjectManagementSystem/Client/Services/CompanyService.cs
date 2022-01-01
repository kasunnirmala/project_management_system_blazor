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

        public async Task<List<Company>> CreateCompany(Company company)
        {
            var result =await _httpClient.PostAsJsonAsync<Company>($"api/company",company);
            var companies = await result.Content.ReadFromJsonAsync<List<Company>>();
            return companies;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _httpClient.GetFromJsonAsync<List<Company>>("api/company");
        }

        public async Task<Company> GetSingleCompany(int id)
        {
            return await _httpClient.GetFromJsonAsync<Company>($"api/company/{id}");
        }
    }
}
