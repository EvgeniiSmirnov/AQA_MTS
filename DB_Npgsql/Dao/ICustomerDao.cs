using DB_Npgsql.Models;

namespace DB_Npgsql.Dao;

public interface ICustomerDao
{
    List<Customer> GetAll();
    Customer GetById(int id);
    int Add(Customer customer);
    int Update(Customer customer);
    int Delete(int? id);

    void Create();
    void Drop();
}