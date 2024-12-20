using ContactManagement.Forms.Action;
using ContactManagerLibrary.Services.Interfaces;

namespace ContactManagement.Forms.Other
{
    public partial class Search : Form
    {
        private readonly Main _mainForm;
        private readonly IDataCollector _dataCollector;

        public Search(IDataCollector dataCollector, Main mainForm)
        {
            _mainForm = mainForm;
            _dataCollector = dataCollector;

            InitializeComponent();
        }

        private async void refSearchBtn_Click(object sender, EventArgs e)
        {
            var refId = refSearchTextBox.Text.Trim();

            var customerDetails = await _dataCollector.GetCustomerDetailsAsync(refId);

            if(customerDetails != null)
            {
                _mainForm.actionPanel.Visible = true;
                _mainForm.otherPanel.Visible = false;
                _mainForm.workQueuePanel.Visible = false;

                //Populate details form
                var detailsForm = new Details();

                _mainForm.LoadFormIntoDetailsPanel(detailsForm);
                detailsForm.referenceIdTextBox.Text = customerDetails.ReferenceId;
                detailsForm.companyNameTextBox.Text = customerDetails.CompanyName;
                detailsForm.busnessAccountCheckBox.Checked = customerDetails.BusinessAccount;
                detailsForm.businessEmailAddressTextBox.Text = customerDetails.BusinessEmail;

                //Add 1st address and store remaining
                detailsForm.titleTextBox.Text = string.Empty; //Needs adding to sql
                detailsForm.fullNameTextBox.Text = customerDetails.Addresses[0].fullName;
                detailsForm.address1TextBox.Text = customerDetails.Addresses[0].address1;
                detailsForm.address2TextBox.Text = customerDetails.Addresses[0].address2;
                detailsForm.address3TextBox.Text = customerDetails.Addresses[0].address3;
                detailsForm.address4TextBox.Text = customerDetails.Addresses[0].address4;
                detailsForm.address5TextBox.Text = customerDetails.Addresses[0].address5;
                detailsForm.postCodeTextBox.Text = customerDetails.Addresses[0].postCode;
                detailsForm.emailAddressTextBox.Text = customerDetails.Addresses[0].emailAddress;

                _mainForm.addresses = customerDetails.Addresses;
            }
        }
    }
}