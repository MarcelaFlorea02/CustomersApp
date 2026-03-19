using System.Configuration;
using Microsoft.Data.SqlClient;

namespace CustomersApp;

public class DBHelper
{
    private readonly string _dbConnectionString;
    public DBHelper()
    {
        _dbConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }

    //GetAllCustomer 
    public List<Customer> GetCustomers()
    {
        var customerList = new List<Customer>();

        using var connection = new SqlConnection(_dbConnectionString);

        const string sql = @"
SELECT Id, FirstName, LastName, Email, Phone, CreatedAt 
FROM Customer";

        connection.Open();
        using var command = new SqlCommand(sql, connection);

        using var reader = command.ExecuteReader();

        int ordId = reader.GetOrdinal("Id");
        int ordFirstName = reader.GetOrdinal("FirstName");
        int ordLastName = reader.GetOrdinal("LastName");
        int ordEmail = reader.GetOrdinal("Email");
        int ordPhone = reader.GetOrdinal("Phone");
        int ordCreatedAt = reader.GetOrdinal("CreatedAt");

        while (reader.Read())
        {
            var customer = new Customer()
            {
                Id = reader.GetInt32(ordId),
                FirstName = reader.GetString(ordFirstName),
                LastName = reader.GetString(ordLastName),
                Email = reader.GetString(ordEmail),
                Phone = reader.GetString(ordPhone),
                CreatedAt = reader.GetDateTime(ordCreatedAt)
            };
            customerList.Add(customer);
        }
        return customerList;
    }   

    //CrateCustomer 

    //UpdateCustomer 

    //DeleteCustomer
}
