using NLog;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Services;

namespace TestRailComplexApi.Tests;

public class BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;

    [OneTimeSetUp]
    public void SetUpApi()
    {
        var restClient = new RestClientExtended();
        ProjectService = new ProjectService(restClient);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        ProjectService.Dispose();
    }
}
