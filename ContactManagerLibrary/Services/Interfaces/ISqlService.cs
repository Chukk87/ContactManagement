using System.Data;

namespace ContactManagerLibrary.Services.Interfaces
{
    public interface ISqlService
    {
        Task<DataTable> GetCustomerDetailsAsync(string referenceId);
        Task<DataTable> GetCustomersAddressesAsync(Guid id);
    }
}