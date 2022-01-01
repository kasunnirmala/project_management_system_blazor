using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public class TicketService:ITicketService
    {
        private readonly HttpClient _httpClient;

        public TicketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _httpClient.GetFromJsonAsync<List<Ticket>>("api/ticket");
        }

        public async Task<Ticket> GetSingleTicket(int id)
        {
            return await _httpClient.GetFromJsonAsync<Ticket>($"api/ticket/{id}");
        }
    }
}
