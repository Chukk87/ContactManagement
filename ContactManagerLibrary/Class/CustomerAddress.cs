namespace ContactManagerLibrary.Class
{
    public class CustomerAddress
    {
        public string fullName { get; }
        public string address1 { get; }
        public string address2 { get; }
        public string address3 { get; }
        public string address4 { get; }
        public string address5 { get; }
        public string postCode { get; }
        public string emailAddress { get; }

        public CustomerAddress(string fullName, string address1, string address2, string address3, string address4, string address5, string postCode, string emailAddress)
        {
            this.fullName = fullName;
            this.address1 = address1;
            this.address2 = address2;
            this.address3 = address3;
            this.address4 = address4;
            this.address5 = address5;
            this.postCode = postCode;
            this.emailAddress = emailAddress;
        }
    }
}
