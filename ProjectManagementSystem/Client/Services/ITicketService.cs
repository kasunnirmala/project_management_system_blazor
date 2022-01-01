using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetTickets();

        Task<Ticket> GetSingleTicket(int id);
    }
}
