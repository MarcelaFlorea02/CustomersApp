using System.Configuration;
using System.Diagnostics;
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
    public async Task<List<Customer>> GetCustomersAsync()
    {
        try
        {
            var customerList = new List<Customer>();

            using var connection = new SqlConnection(_dbConnectionString);

            const string sql = @"
SELECT Id, FirstName, LastName, Email, Phone, CreatedAt 
FROM Customer";

            await connection.OpenAsync();
            using var command = new SqlCommand(sql, connection);

            using var reader = await command.ExecuteReaderAsync();

            int ordId = reader.GetOrdinal("Id");
            int ordFirstName = reader.GetOrdinal("FirstName");
            int ordLastName = reader.GetOrdinal("LastName");
            int ordEmail = reader.GetOrdinal("Email");
            int ordPhone = reader.GetOrdinal("Phone");
            int ordCreatedAt = reader.GetOrdinal("CreatedAt");

            while (await reader.ReadAsync())
            {
                var customer = new Customer()
                {
                    Id = reader.GetInt32(ordId),
                    FirstName = reader.GetString(ordFirstName),
                    LastName = reader.GetString(ordLastName),
                    Email = reader.GetString(ordEmail),
                    Phone = reader.IsDBNull(ordPhone) ? null : reader.GetString(ordPhone),
                    CreatedAt = reader.GetDateTime(ordCreatedAt)
                };
                customerList.Add(customer);
            }
            return customerList;
        }
        catch (Exception ex)
        {
            Trace.TraceError("GetCustomersAsync throw an error: {0}", ex);
            throw;
        }
    }

    //CrateCustomer 
    public async Task AddCustomerAsync(Customer customer)
    {
        try
        {
            using var connection = new SqlConnection(_dbConnectionString);

            const string sql = @"
INSERT INTO Customer (FirstName, LastName, Email, Phone)
VALUES (@FirstName, @LastName, @Email, @Phone)";

            await connection.OpenAsync();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@LastName", customer.LastName);
            command.Parameters.AddWithValue("@Email", customer.Email);
            command.Parameters.AddWithValue("@Phone", customer.Phone);

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("AddCustomersAsync throw an error: {0}", ex);
            throw;
        }

    }

    //UpdateCustomer 
    public async Task UpdateCustomerAsync(Customer customer)
    {
        try
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

            await connection.OpenAsync();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@LastName", customer.LastName);
            command.Parameters.AddWithValue("@Email", customer.Email);
            command.Parameters.AddWithValue("@Phone", customer.Phone);
            command.Parameters.AddWithValue("@Id", customer.Id);

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("UpdateCustomerAsync throw an error: {0}", ex);
            throw;
        }
    }

    //DeleteCustomer
    public async Task DeleteCustomerAsync(int id)
    {
        try
        {
            using var connection = new SqlConnection(_dbConnectionString);

            const string sql = @"
DELETE FROM Customer
WHERE Id=@Id";

            await connection.OpenAsync();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("DeleteCustomerAsync throw an error: {0}", ex);
            throw;
        }
    }
}
