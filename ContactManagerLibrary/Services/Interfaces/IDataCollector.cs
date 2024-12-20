using ContactManagerLibrary.Class;

namespace ContactManagerLibrary.Services.Interfaces
{
    public interface IDataCollector
    {
        Task<CustomerDetails> GetCustomerDetailsAsync(string customerId);
    }
}