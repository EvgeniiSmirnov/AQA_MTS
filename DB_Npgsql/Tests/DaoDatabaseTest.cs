using DB_Npgsql.Connector;
using DB_Npgsql.Dao;
using DB_Npgsql.Models;
using NLog;

namespace DB_Npgsql.Tests;

public class DaoDatabaseTest
{
    private DBConnector? _dbConnector;
    private readonly Logger _logger = LogManager.GetLogger(nameof(DatabaseTest));
    private CustomerDao? _customerDao;

    [OneTimeSetUp]
    public void SetupConnection()
    {
        _dbConnector = new DBConnector();
        _customerDao = new CustomerDao(_dbConnector.Connection);

        _customerDao.Drop();
        _customerDao.Create();
        _customerDao.Add(new Customer
        {
            Firstname = "Test",
            Lastname = "Testov",
            Email = "test@test.com",
            Age = 1
        });
    }

    [Test]
    [Order(1)]
    public void AddCustomerTest()
    {
        _logger.Info("Started AddCustomerTest");

        Assert.That(_customerDao.Add(new Customer
        {
            Firstname = "John",
            Lastname = "Doe",
            Email = "testEmail@test.com",
            Age = 30
        }), Is.EqualTo(1));

        _logger.Info("Completed AddCustomerTest");
    }

    [Test]
    [Order(2)]
    public void GetAllCustomersTest()
    {
        _logger.Info("GetAllCustomersTest started...");
        var customersList = _customerDao?.GetAll();

        Assert.That(customersList, Has.Count.GreaterThan(1));

        _logger.Info("GetAllCustomersTest completed...");
    }

    [Test]
    [Order(3)]
    public void DeleteCustomerTest()
    {
        _logger.Info("DeleteCustomerTest started...");

        Assert.That(_customerDao?.Delete(_customerDao?.GetAll()[0].Id), Is.EqualTo(1));

        _logger.Info("DeleteCustomerTest completed...");
    }

    [OneTimeTearDown]
    public void CloseConnection()
    {
        _dbConnector?.CloseConnection();
    }
}
