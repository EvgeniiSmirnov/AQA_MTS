using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface ICaseServices
{
    Task<Case> GetCase(string caseId);
    Task<Case> AddCase(string sectionId, Case newCase);
    Task<Case> UpdateCase(Case caseOriginal, Case caseUpdate);
    HttpStatusCode MoveCasesToSection(string sectionId, string newSectionId, string caseIds);
    HttpStatusCode DeleteCase(string caseId);
}