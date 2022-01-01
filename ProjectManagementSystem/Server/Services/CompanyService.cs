using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Server.Data;
using ProjectManagementSystem.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Server.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<bool> CreateCompany(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCompany(Company company)
        {
            _context.Remove(company);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetSingleCompany(int id)
        {
            return await _context.Companies.FirstOrDefaultAsync(c=>c.Id.Equals(id));
        }

        public async Task<bool> UpdateCompany(Company company)
        {
            _context.Companies.Update(company);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
