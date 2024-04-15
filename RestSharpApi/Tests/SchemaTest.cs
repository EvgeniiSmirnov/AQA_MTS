using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpApi.Models;
using System.Net;
using System.Text.Json;

namespace RestSharpApi.Tests;

public class SchemaTest
{

    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://smirnov777.testrail.io/";

    [Test]
    public void JsonSchemaTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "Project 125",
            Announcement = "Test project description",
            IsShowAnnouncement = true,
            SuiteMode = 2
        };

        //Загрузка и создание Json схемы из файла
        string schemaJson = File.ReadAllText(@"Resources/schema.json");

        JSchema schema = JSchema.Parse(schemaJson);

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("mbural66@gmail.com", "Americana#1978")
        };

        var client = new RestClient(options);

        // Setup Request
        Logger.Info("expectedProject: " + JsonSerializer.Serialize(expectedProject));

        var request = new RestRequest(endpoint)
            .AddJsonBody(expectedProject);

        // Execute Request
        var response = client.ExecutePost(request);

        Logger.Info("response: " + JsonSerializer.Serialize(response.Content));

        if (response.StatusCode == HttpStatusCode.OK)
        {
            // Получаем тело ответа в виде JObject
            JObject responseData = JObject.Parse(response.Content);

            Assert.That(responseData.IsValid(schema));
        }
    }

    [Test]
    public void SchemaTest1()
    {
        string schemaJson = @"{
            'description': 'A person',
            'type': 'object',
            'properties':
                {
                    'name': {'type':'string'},
                    'hobbies': {
                        'type': 'array',
                        'items': {'type':'string'}
                    }
                }
        }";

        JsonSchema schema = JsonSchema.Parse(schemaJson);

        JObject person = JObject.Parse(@"{'name': 'James','hobbies': ['.NET', 'Blogging', 'Reading', 'Xbox', 'LOLCATS']}");
        Assert.That(person.IsValid(schema));
    }
}