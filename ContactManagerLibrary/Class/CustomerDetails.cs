namespace ContactManagerLibrary.Class
{
    public class CustomerDetails
    {
        public Guid Id { get; }
        public string ReferenceId { get; } = string.Empty;
        public string CompanyName { get; } = string.Empty;
        public bool BusinessAccount { get; }
        public string BusinessEmail { get; } = string.Empty;
        public List<CustomerAddress> Addresses { get; set;  } = new List<CustomerAddress>();

        public CustomerDetails()
        {
        }

        public CustomerDetails(Guid id, string referenceId, string companyName, bool businessAccount, string businessEmail)
        {
            Id = id;
            ReferenceId = referenceId;
            CompanyName = companyName;
            BusinessAccount = businessAccount;
            BusinessEmail = businessEmail;
        }
    }
}