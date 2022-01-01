using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanies();

        Task<Company> GetSingleCompany(int id);

        Task<List<Company>> CreateCompany(Company company);
    }
}
