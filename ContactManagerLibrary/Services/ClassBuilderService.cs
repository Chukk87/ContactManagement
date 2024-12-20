using ContactManagerLibrary.Class;
using ContactManagerLibrary.Services.Interfaces;
using System.Data;

namespace ContactManagerLibrary.Services
{
    public class ClassBuilderService : IClassBuilderService
    {
        public CustomerDetails BuildCustomerDetails(DataTable customerDetailsTable, DataTable customerAddressTable)
        {
            if(customerDetailsTable.Rows.Count == 0)
            {
                return new CustomerDetails();
            }

            var customerDetails = new CustomerDetails(
                customerDetailsTable.Rows[0].Field<Guid>("Id"),
                customerDetailsTable.Rows[0].Field<string>("ReferenceId"),
                customerDetailsTable.Rows[0].Field<string>("CompanyName"),
                customerDetailsTable.Rows[0].Field<bool>("BusinessAccount"),
                customerDetailsTable.Rows[0].Field<string>("BusinessEmail")
                );

            if (customerAddressTable.Rows.Count == 0)
            {
                return customerDetails;
            }
            else
            {
                foreach(DataRow row in customerAddressTable.Rows)
                {
                    var address = new CustomerAddress(
                        row.Field<string>("FullName"),
                        row.Field<string>("Address1"),
                        row.Field<string>("Address2"),
                        row.Field<string>("Address3"),
                        row.Field<string>("Address4"),
                        row.Field<string>("Address5"),
                        row.Field<string>("PostCode"),
                        row.Field<string>("EmailAddress")
                        );

                    customerDetails.Addresses.Add(address);
                }
            }

            return customerDetails;
        }
    }
}