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
    public void AddCustomer(Customer customer)
    {
        using var connection = new SqlConnection(_dbConnectionString);

        const string sql = @"
INSERT INTO Customer (FirstName, LastName, Email, Phone)
VALUES (@FirstName, @LastName, @Email, @Phone)";

        connection.Open();
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@FirstName", customer.FirstName);
        command.Parameters.AddWithValue("@LastName", customer.LastName);
        command.Parameters.AddWithValue("@Email", customer.Email);
        command.Parameters.AddWithValue("@Phone", customer.Phone);

        command.ExecuteNonQuery();

    }

    //UpdateCustomer 
    public void UpdateCustomer(Customer customer)
    {
        using var connection = new SqlConnection(_dbConnectionString);

        const string sql = @"
UPDATE Customer 
SET 
FirstName=@FirstName, 
LastName=@LastName,
Email=@Email,
Phone=@Phone
WHERE Id=@Id";

        connection.Open();
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@FirstName", customer.FirstName);
        command.Parameters.AddWithValue("@LastName", customer.LastName);
        command.Parameters.AddWithValue("@Email", customer.Email);
        command.Parameters.AddWithValue("@Phone", customer.Phone);
        command.Parameters.AddWithValue("@Id", customer.Id);

        command.ExecuteNonQuery();
    }

    //DeleteCustomer
    public void DeleteCustomer(int id)
    {
        using var connection = new SqlConnection(_dbConnectionString);

        const string sql = @"
DELETE FROM Customer
WHERE Id=@Id";

        connection.Open();
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);

        command.ExecuteNonQuery();
    }
}
