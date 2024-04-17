using DB_Npgsql.Models;
using NLog;
using Npgsql;

namespace DB_Npgsql.Dao;

public class CustomerDao : ICustomerDao
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private readonly NpgsqlConnection _connection;

    public CustomerDao(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public List<Customer> GetAll()
    {
        var customers = new List<Customer>();

        var cmd = new NpgsqlCommand("SELECT * FROM customers2;", _connection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer()
            {
                Id = reader.GetInt32(0),
                Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                Email = reader.GetString(reader.GetOrdinal("email")),
                Age = reader.GetInt32(reader.GetOrdinal("age")),
            };

            _logger.Info(customer);

            customers.Add(customer);
        }

        return customers;
    }

    public Customer GetById(int id)
    {
        var customer = new Customer();

        using (var cmd = new NpgsqlCommand("SELECT * FROM customers2 WHERE id = @id;", _connection))
        {
            cmd.Parameters.AddWithValue("id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Customer()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                        Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Age = reader.GetInt32(reader.GetOrdinal("age"))
                    };
                }
            }

            return null;
        }
    }

    public int Add(Customer customer)
    {
        using (var cmd = new NpgsqlCommand(
                   "insert into customers2 (firstname, lastname, email, age) " +
                   $"values (@firstname, @lastname, @email, @age);", _connection))
        {
            cmd.Parameters.AddWithValue("firstname", customer.Firstname);
            cmd.Parameters.AddWithValue("lastname", customer.Lastname);
            cmd.Parameters.AddWithValue("email", customer.Email);
            cmd.Parameters.AddWithValue("age", customer.Age);

            return cmd.ExecuteNonQuery();
        }
    }

    public int Update(Customer customer)
    {
        using (var command = new NpgsqlCommand("UPDATE customers2 SET firstname = @firstname, lastname = @lastname, " +
                                               "email = @email, age = @age WHERE id = @id", _connection))
        {
            command.Parameters.AddWithValue("firstname", customer.Firstname);
            command.Parameters.AddWithValue("lastname", customer.Lastname);
            command.Parameters.AddWithValue("email", customer.Email);
            command.Parameters.AddWithValue("age", customer.Age);
            command.Parameters.AddWithValue("id", customer.Id);

            return command.ExecuteNonQuery();
        }
    }

    public int Delete(int? id)
    {
        using (var command = new NpgsqlCommand("DELETE FROM customers2 WHERE id = @id",
                   _connection))
        {
            command.Parameters.AddWithValue("id", id);

            return command.ExecuteNonQuery();
        }
    }

    public void Create()
    {
        var cmd = "create table customers2 (id serial " +
                  "primary key, " +
                  "firstname varchar(30)," +
                  "lastname  varchar(30)," +
                  "email     varchar(30)," +
                  "age       integer);";

        using (var command = new NpgsqlCommand(cmd, _connection))
        {
            command.ExecuteNonQuery();
        }
    }

    public void Drop()
    {
        var dropTableSQL = "DROP TABLE if exists customers2;";

        using (var command = new NpgsqlCommand(dropTableSQL, _connection))
        {
            command.ExecuteNonQuery();
        }
    }
}
