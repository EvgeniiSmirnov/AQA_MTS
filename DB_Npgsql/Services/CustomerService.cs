using DB_Npgsql.Models;
using NLog;
using Npgsql;

namespace DB_Npgsql.Services;

public class CustomerService
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private readonly NpgsqlConnection _connection;

    public CustomerService(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public List<Customer> GetAllCustomers()
    {
        var customers = new List<Customer>();

        var cmd = new NpgsqlCommand("SELECT * FROM Customers;", _connection);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer()
            {
                Id = reader.GetInt32(0),
                Firstname = reader.GetString(reader.GetOrdinal("Firstname")),
                Lastname = reader.GetString(reader.GetOrdinal("Lastname")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Age = reader.GetInt32(reader.GetOrdinal("Age")),
            };

            _logger.Info(customer);

            customers.Add(customer);
        }

        return customers;
    }

    public int AddCustomer(Customer customer)
    {
        var cmd = new NpgsqlCommand(
                "insert into \"customers\" (\"firstname\", \"lastname\", \"email\", \"age\") " +
                $"values ('{customer.Firstname}', '{customer.Lastname}', '{customer.Email}', {customer.Age});",
                _connection);

        return cmd.ExecuteNonQuery();
    }

    public int DeleteCustomer(Customer customer)
    {
        using var cmd = new NpgsqlCommand(
            "delete from \"customers\" where \"firstname\" = $1 and \"lastname\" = $2;",
            _connection)
        {
            Parameters =
            {
                new(){Value = customer.Firstname},
                new(){Value = customer.Lastname},
            }
        };

        return cmd.ExecuteNonQuery();
    }
}