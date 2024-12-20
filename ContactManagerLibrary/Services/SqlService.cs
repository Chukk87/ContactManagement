using ContactManagerLibrary.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ContactManagerLibrary.Services
{
    public class SqlService : ISqlService
    {
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ContactManagement;Integrated Security=True;TrustServerCertificate=True";

        public async Task<DataTable> GetCustomerDetailsAsync(string referenceId)
        {
            var parameters = new[]
{
                new SqlParameter("@Id", referenceId),
            };

            return await ExecuteQueryAsync("[dbo].[GetCustomerDetails]", parameters);
        }

        public async Task<DataTable> GetCustomersAddressesAsync(Guid guidId)
        {
            var parameters = new[]
            {
                new SqlParameter("@Id", guidId),
            };

            return await ExecuteQueryAsync("[dbo].[GetCustomerAddresses]", parameters);
        }

        private async Task<DataTable> ExecuteQueryAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync().ConfigureAwait(false);

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            resultTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    throw;
                }
            }

            return resultTable;
        }
    }
}