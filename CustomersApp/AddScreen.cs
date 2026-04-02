using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
