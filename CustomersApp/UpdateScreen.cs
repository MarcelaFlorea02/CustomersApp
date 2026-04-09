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
            }
            catch (Exception ex)
            {
                Trace.TraceError("Update throw an error: {0}", ex);
                MessageBox.Show("An error ocurred while updating the customer. ", "Error on update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
