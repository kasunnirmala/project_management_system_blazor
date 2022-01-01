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
    public class TicketController : ControllerBase
    {
        public List<Ticket> tickets = new List<Ticket>
        {
            new Ticket { Id= 1, Title = "Ticket One",Description="Ticket one description",Status="Open"},
            new Ticket { Id= 2, Title = "Ticket Two",Description="Ticket two description",Status="Close"}
        };

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            return Ok(tickets);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleTicket(int id)
        {
            var ticket = tickets.FirstOrDefault(h => h.Id == id);
            if (ticket == null)
            {
                return NotFound("The ticket is not in the system");
            }
            else
            {
                return Ok(ticket);
            }

        }
    }
}
