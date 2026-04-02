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
    public partial class DashboardScreen : Form
    {
        public DashboardScreen()
        {
            InitializeComponent();
        }

        public async Task LoadDataAsync()
        {
            DBHelper dBHelper = new DBHelper();
            var customerList = new List<Customer>();

            //get customers from db 
            customerList = await dBHelper.GetCustomersAsync();

            //construct the table 
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("CreatedAt", typeof(DateTime));

            //add rows into the table 
            foreach (var customer in customerList)
            {
                dataTable.Rows.Add(customer.Id, customer.FirstName, customer.LastName,
                    customer.Email, customer.Phone, customer.CreatedAt);
            }

            //add table into dataGridView 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = dataTable;
        }

        private async void DashboardScreen_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();

            var selectedCustomer = dataGridView1.SelectedRows[0];
            var customerId = Convert.ToInt32(selectedCustomer.Cells["Id"].Value);

            await dBHelper.DeleteCustomerAsync(customerId);
            await LoadDataAsync();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddScreen addScreen = new AddScreen(this);
            addScreen.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var firstName = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
            var lastName = dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString();
            var email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
            var phone = dataGridView1.SelectedRows[0].Cells["Phone"].Value.ToString();

            var customer = new Customer()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone
            };

            UpdateScreen updateScreen = new UpdateScreen(customer, this);
            updateScreen.Show();
        }
    }
}
