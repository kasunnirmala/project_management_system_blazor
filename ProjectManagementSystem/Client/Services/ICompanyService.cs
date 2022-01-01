using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public interface ICompanyService
    {
        public Task<List<Company>> GetCompanies();

        public Task<Company> GetSingleCompany(int id);

        public Task<bool> CreateCompany(Company company);
        public Task<bool> UpdateCompany(Company company);
        public Task<bool> DeleteCompany(int id);
    }
}
