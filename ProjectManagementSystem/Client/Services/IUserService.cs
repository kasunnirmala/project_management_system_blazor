using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();

        Task<User> GetSingleUser(int id);
    }
}
