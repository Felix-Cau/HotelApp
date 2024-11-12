using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;

namespace HotelApp.Views
{
    public partial class FormCustomer : Form
    {
        Customer selectedCustomer = new();
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
            selectedCustomer.FullName = textBoxFullName.Text.Trim();
            selectedCustomer.Address = textBoxAddress.Text.Trim();
            selectedCustomer.PostalCode = int.Parse(textBoxPostalCode.Text.Trim());
            selectedCustomer.City = textBoxCity.Text.Trim();
            selectedCustomer.Country = textBoxCountry.Text.Trim();
            selectedCustomer.Phone = textBoxPhoneNumber.Text.Trim();
            selectedCustomer.Email = textBoxEmail.Text.Trim();

            CustomerRepo customerRepo = new();
            customerRepo.UpdateCustomer(selectedCustomer);

            MessageBox.Show("Customer updated successfully.");

            ClearAllFields();
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new()
            {
                FullName = textBoxFullName.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                PostalCode = int.Parse(textBoxPostalCode.Text.Trim()),
                City = textBoxCity.Text.Trim(),
                Country = textBoxCountry.Text.Trim(),
                Phone = textBoxPhoneNumber.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
            };

            selectedCustomer = newCustomer;

            CustomerRepo customerRepo = new();
            customerRepo.AddCustomer(selectedCustomer);

            MessageBox.Show("Customer saved.");

            ClearAllFields();
        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            CustomerRepo _context = new();

            _context.DeleteCustomer(selectedCustomer);

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
    }
}
