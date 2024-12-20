using ContactManagerLibrary.Class;
using ContactManagerLibrary.Services.Interfaces;
using System.Data;

namespace ContactManagerLibrary.Services
{
    public class DataCollector : IDataCollector
    {
        private ISqlService _sqlService;
        private IClassBuilderService _classBuilderService;

        public DataCollector(ISqlService sqlService, IClassBuilderService classBuilderService)
        {
            _sqlService = sqlService;
            _classBuilderService = classBuilderService;
        }

        public async Task<CustomerDetails> GetCustomerDetailsAsync(string referenceId)
        {
            try
            {
                var customerId = Guid.Empty;

                var customerDetailsTable = await _sqlService.GetCustomerDetailsAsync(referenceId);
                if (customerDetailsTable == null || customerDetailsTable.Rows.Count == 0)
                {
                    return null;
                }

                customerId = customerDetailsTable.Rows[0].Field<Guid>("Id");

                var customerAddressesTable = await _sqlService.GetCustomersAddressesAsync(customerId);
                if (customerAddressesTable == null)
                {
                    throw new InvalidOperationException($"No addresses found for CustomerId: {customerId}");
                }

                var customerDetails = _classBuilderService.BuildCustomerDetails(customerDetailsTable, customerAddressesTable);
                return customerDetails;
            }
            catch (Exception ex)
            {
                throw; // Rethrow or handle as per your requirements
            }
        }
    }
}