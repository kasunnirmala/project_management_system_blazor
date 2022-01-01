using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementSystem.Server.Services;
using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService) {
            _companyService = companyService;
        }
       

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            List<Company> companies=await _companyService.GetCompanies();
            return Ok(companies);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleCompany(int id)
        {
            Company company = await _companyService.GetSingleCompany(id);
            return Ok(company);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            bool isCompany = await _companyService.CreateCompany(company);
            return Ok(isCompany);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(Company company)
        {
            bool isCompany = await _companyService.UpdateCompany(company);
            return Ok(isCompany);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            Company company = await _companyService.GetSingleCompany(id);
            bool isCompany = await _companyService.DeleteCompany(company);
            return Ok(isCompany);
        }
    }
}
