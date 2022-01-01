using ProjectManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Client.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects();

        Task<Project> GetSingleProject(int id);
    }
}
