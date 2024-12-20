using ContactManagerLibrary.Class;
using System.Data;

namespace ContactManagerLibrary.Services.Interfaces
{
    public interface IClassBuilderService
    {
        CustomerDetails BuildCustomerDetails(DataTable customerDetailsTable, DataTable customerAddressTable);
    }
}
