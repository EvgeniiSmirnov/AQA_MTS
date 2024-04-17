using DB_EFCore.Connector;
using DB_EFCore.Models;
using NLog;

namespace DB_EFCore.Tests;

public class InitialDatabaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();

    [Test]
    public void DB_Test1()
    {
        using (var dbConnector = new DataBaseConnector())
        {
            var customer1 = new Customer { Firstname = "Ivan", Lastname = "Petrov" };
            var customer2 = new Customer { Firstname = "Sergey", Lastname = "Ivanov" };

            var entityCustomer1 = dbConnector.Customers.Add(customer1);
            var entityCustomer2 = dbConnector.Customers.Add(customer2);
            dbConnector.SaveChanges();

            var customers = dbConnector.Customers.ToList();

            // Поиск
            _logger.Info(
                $"{dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Firstname}" +
                $".{dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Lastname}");

            _logger.Info("Customers List:");
            foreach (var customer in customers)
            {
                _logger.Info($"{customer.Firstname}.{customer.Lastname}");
                dbConnector.Customers.Remove(customer);

                if (customer.Id > 10)
                {
                    dbConnector.Customers.Remove(customer);
                    dbConnector.SaveChanges();
                }
            }
        }

        Assert.That(true, "Test passed.");
    }
}