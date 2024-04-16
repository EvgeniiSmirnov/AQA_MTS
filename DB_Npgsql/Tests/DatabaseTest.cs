using DB_Npgsql.Connector;
using DB_Npgsql.Services;
using NLog;

namespace DB_Npgsql.Tests;

public class DatabaseTest
{
    private DBConnector? _dbConnector;
    private readonly Logger _logger = LogManager.GetLogger(nameof(DatabaseTest));
    private CustomerService? _customerService;

    [OneTimeSetUp]
    public void SetupConnection()
    {
        _dbConnector = new DBConnector();
        _customerService = new CustomerService(_dbConnector.Connection);
    }

    [Test]
    public void GetAllCustomersTest()
    {
        _logger.Info("Started GetAllCustomersTest");

        Assert.That(_customerService!.GetAllCustomers().Count, Is.EqualTo(5));

        _logger.Info("Completed GetAllCustomersTest");
    }

    [OneTimeTearDown]
    public void TearDownConnection()
    {
        _dbConnector!.CloseConnection();
    }
}
