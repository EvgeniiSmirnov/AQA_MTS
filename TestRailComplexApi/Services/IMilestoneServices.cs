using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface IMilestoneServices
{
    Task<Milestone> GetMilestone(string milestoneId);
    Task<Milestone> AddMilestone(string projectId, Milestone milestone);
    Task<Milestone> UpdateMilestone(Milestone milestone, Milestone milestoneUpdate);
    HttpStatusCode DeleteMilestone(string milestoneId);
}