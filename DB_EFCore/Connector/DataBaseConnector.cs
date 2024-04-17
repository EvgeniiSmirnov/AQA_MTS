using DB_EFCore.Helpers.Configuration;
using DB_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_EFCore.Connector;

public class DataBaseConnector : DbContext
{
    public DbSet<Customer>? Customers { get; set; }

    public DataBaseConnector()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            $"Host={Configurator.DbSettings.DB_Server};" +
            $"Port={Configurator.DbSettings.DB_Port};" +
            $"Database={Configurator.DbSettings.DB_Name};" +
            $"User Id={Configurator.DbSettings.DB_Username};" +
            $"Password={Configurator.DbSettings.DB_Password};";

        optionsBuilder.UseNpgsql(connectionString);
    }
}