using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public List<Company> companies = new List<Company>
        {
            new Company { Id= 1, Name = "ABC Company",Description = "Software Company",Address="Address one"},
            new Company { Id= 2, Name = "Logic Company",Description = "Software Company",Address="Address Two"}
        };

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            return Ok(companies);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleCompany(int id)
        {
            var company = companies.FirstOrDefault(h => h.Id == id);
            if (company == null)
            {
                return NotFound("The company is not in the system");
            }
            else
            {
                return Ok(company);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            companies.Add(company);
        }
    }
}
