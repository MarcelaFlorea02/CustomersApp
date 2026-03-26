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

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();
            var customerList = new List<Customer>();

            //get customers from db 
            customerList = dBHelper.GetCustomers();

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();

            var selectedCustomer = dataGridView1.SelectedRows[0];
            var customerId = Convert.ToInt32(selectedCustomer.Cells["Id"].Value);

            dBHelper.DeleteCustomer(customerId);

        }
    }
}
