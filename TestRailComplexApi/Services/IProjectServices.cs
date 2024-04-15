using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface IProjectServices
{
    Task<Project> GetProject(string projectId);
    Task<Projects> GetProjects();
    Task<Project> AddProject(Project project);
    Task<Project> UpdateProject(Project project);
    HttpStatusCode DeleteProject(string projectId);
}