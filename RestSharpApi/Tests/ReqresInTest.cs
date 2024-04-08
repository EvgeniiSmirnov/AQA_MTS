using NLog;
using RestSharp;
using System.Net;

namespace RestSharpApi.Tests;

public class ReqresInTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://reqres.in";

    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "/api/users/2"; // OK

        // Setup Rest Client
        var client = new RestClient(BaseRestUri);

        // Setup Request
        var request = new RestRequest(endpoint);

        // Execute Request
        var response = client.ExecuteGet(request);

        Logger.Info(response.Content);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public void SimplePostTest()
    {
        const string endpoint = "/api/users";

        // Setup Rest Client
        var client = new RestClient(BaseRestUri);

        // Setup Request
        var request = new RestRequest(endpoint);
        request.AddJsonBody("{\"name\": \"morpheus\",\"job\": \"leader\"}");

        // Execute Request
        var response = client.ExecutePost(request);

        Logger.Info(response.Content);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }
}