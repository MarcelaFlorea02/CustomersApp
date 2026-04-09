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
    public partial class AddScreen : Form
    {
        DashboardScreen _parent;
        public AddScreen(DashboardScreen parent)
        {
            _parent = parent;
            InitializeComponent();
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
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    Email = emailInput.Text,
                    Phone = phoneInput.Text
                };

                DBHelper dBHelper = new DBHelper();

                await dBHelper.AddCustomerAsync(customer);
                await _parent.LoadDataAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                Trace.TraceError("Add Customer throw an error: {0}", ex);
                MessageBox.Show("An error ocurred while trying to add the customer. ", "Error on add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
