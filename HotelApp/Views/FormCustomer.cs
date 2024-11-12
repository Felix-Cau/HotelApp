using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;

namespace HotelApp.Views
{
    public partial class FormCustomer : Form
    {
        private Customer selectedCustomer = new();
        private readonly CustomerRepo repo = new();
        public FormCustomer()
        {
            InitializeComponent();
        }
        public FormCustomer(Customer customer)
        {
            selectedCustomer = customer;
            InitializeComponent();
            LoadSelectedCustomer();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            int parsedPostalCode = int.TryParse(textBoxPostalCode.Text.Replace(" ", ""), out int postalCode) ? postalCode : 0;

            if (parsedPostalCode == 0)
            {
                MessageBox.Show("You did not enter a valid Postal Code with only numbers.");
            }
            else
            {
                UpdateCustomerFields(selectedCustomer, parsedPostalCode);

                repo.UpdateCustomer(selectedCustomer);

                MessageBox.Show("Customer updated successfully.");

                ClearAllFields();
            }
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new();
            selectedCustomer = newCustomer;

            int parsedPostalCode = int.TryParse(textBoxPostalCode.Text.Replace(" ", ""), out int postalCode) ? postalCode : 0;

            if (parsedPostalCode == 0)
            {
                MessageBox.Show("You did not enter a valid Postal Code with only numbers.");
            }
            else
            {
                UpdateCustomerFields(newCustomer, parsedPostalCode);

                repo.AddCustomer(selectedCustomer);

                MessageBox.Show("Customer saved.");

                ClearAllFields();
            }
        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            repo.DeleteCustomer(selectedCustomer);

            ClearAllFields();
        }

        private void ClearAllFields()
        {
            textBoxFullName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxPostalCode.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxCountry.Text = string.Empty;
            textBoxPhoneNumber.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadSelectedCustomer()
        {
            textBoxFullName.Text = selectedCustomer.FullName;
            textBoxAddress.Text = selectedCustomer.Address;
            textBoxPostalCode.Text = selectedCustomer.PostalCode.ToString();
            textBoxCity.Text = selectedCustomer.City.ToString();
            textBoxCountry.Text = selectedCustomer.Country.ToString();
            textBoxPhoneNumber.Text = selectedCustomer.Phone.ToString();
            textBoxEmail.Text = selectedCustomer.Email.ToString();
        }
        private void UpdateCustomerFields(Customer customer, int postalCode)
        {
            customer.FullName = textBoxFullName.Text.Trim();
            customer.Address = textBoxAddress.Text.Trim();
            customer.PostalCode = postalCode;
            customer.City = textBoxCity.Text.Trim();
            customer.Country = textBoxCountry.Text.Trim();
            customer.Phone = textBoxPhoneNumber.Text.Trim();
            customer.Email = textBoxEmail.Text.Trim();
        }
    }
}
