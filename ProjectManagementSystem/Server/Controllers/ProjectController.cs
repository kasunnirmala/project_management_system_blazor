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
    public class ProjectController : ControllerBase
    {
        public List<Project> projects = new List<Project>
        {
            new Project { Id= 1, Name = "Project Name",Description = "Project Description"},
            
        };
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            return Ok(projects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleProject(int id)
        {
            var project = projects.FirstOrDefault(h => h.Id == id);
            if (project == null)
            {
                return NotFound("The company is not in the system");
            }
            else
            {
                return Ok(project);
            }

        }
    }
}
