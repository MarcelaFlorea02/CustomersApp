using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersApp
{
    public partial class UpdateScreen : Form
    {
        Customer _currentCustomer;
        DashboardScreen _parent;
        public UpdateScreen(Customer currentCustomer, DashboardScreen parent)
        {
            InitializeComponent();
            _currentCustomer = currentCustomer;
            _parent = parent;
            firstNameInput.Text = _currentCustomer.FirstName;
            lastNameInput.Text = _currentCustomer.LastName;
            emailInput.Text = _currentCustomer.Email;
            phoneInput.Text = _currentCustomer.Phone;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var validation = CustomerValidator.Validate(firstNameInput.Text, lastNameInput.Text, emailInput.Text, phoneInput.Text);
                if (!validation.IsValid)
                {
                    MessageBox.Show(this, validation.Message, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch (validation.FieldName)
                    {
                        case "firstName": firstNameInput.Focus(); break;
                        case "lastName": lastNameInput.Focus(); break;
                        case "email": emailInput.Focus(); break;
                        case "phone": phoneInput.Focus(); break;
                    }
                    return;
                }
                var customer = new Customer()
                {
                    Id = _currentCustomer.Id,
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    Email = emailInput.Text,
                    Phone = phoneInput.Text
                };

                DBHelper dBHelper = new DBHelper();
                await dBHelper.UpdateCustomerAsync(customer);
                await _parent.LoadDataAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                Trace.TraceError("Update throw an error: {0}", ex);
                MessageBox.Show("An error ocurred while updating the customer. ", "Error on update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
