using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface ISectionServices
{
    Task<Section> AddSection(string projectId, Section section);
    HttpStatusCode DeleteSection(string sectionId);
}