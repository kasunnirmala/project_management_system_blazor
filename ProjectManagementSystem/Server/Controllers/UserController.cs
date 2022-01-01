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
    public class UserController : ControllerBase
    {
        public List<User> users = new List<User>
        {
            new User { Id= 1, Name = "ABC User",Email="ABCD@gmail.com"},
           new User { Id= 2, Name = "ABC User2",Email="ABCD@gmail2.com"}
        };

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleUser(int id)
        {
            var user = users.FirstOrDefault(h => h.Id == id);
            if (user == null)
            {
                return NotFound("The user is not in the system");
            }
            else
            {
                return Ok(user);
            }

        }
    }
}
