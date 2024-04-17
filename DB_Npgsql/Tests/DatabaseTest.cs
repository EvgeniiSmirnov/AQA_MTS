using DB_Npgsql.Connector;
using DB_Npgsql.Models;
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

        Assert.That(_customerService!.GetAllCustomers().Count, Is.EqualTo(6));

        _logger.Info("Completed GetAllCustomersTest");
    }

    [Test]
    public void GetSingleCustomerTest()
    {
        _logger.Info("Started GetSingleCustomerTest");

        Customer actualCustomer = _customerService!.GetCustomerById(1);

        Assert.That(actualCustomer.Firstname, Is.EqualTo("Ольга"));

        _logger.Info("Completed GetSingleCustomerTest");
    }

    [Test]
    public void AddCustomerTest()
    {
        _logger.Info("Started AddCustomerTest");

        var customer = new Customer()
        {
            Firstname = "Test",
            Lastname = "Testov",
            Email = "test@test.com",
            Age = 20
        };

        Assert.That(_customerService!.AddCustomer(customer), Is.EqualTo(1));

        _logger.Info("Добавлен " + customer);

        _logger.Info("Completed AddCustomerTest");
    }

    [Test]
    public void DeleteCustomerTest()
    {
        _logger.Info("Started DeleteCustomerTest");

        var customer = new Customer()
        {
            Firstname = "Test",
            Lastname = "Testov",
            Email = "test@test.com",
            Age = 20
        };

        Assert.That(_customerService!.DeleteCustomer(customer), Is.EqualTo(2));

        _logger.Info("Completed DeleteCustomerTest");
    }

    [OneTimeTearDown]
    public void TearDownConnection()
    {
        _dbConnector!.CloseConnection();
    }
}
