using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // Use the library for app config file using specially here for connectionstring
using System.Data.SqlClient; // Use the library when we need actually sqlconnection
using MiddleTier;
namespace CustomerDataEntryScreen
{
    public partial class FrmSearchCustomers : Form
    {
        public FrmSearchCustomers()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Write some code which will fetch some date from SQL SERVER
            // Open a connection
            //string Connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tarik\Documents\UserDb.mdf;Integrated Security=True;Connect Timeout=30";
            // Bind the data to the UI
            string searchCustomer = "";
            if (txtCustomerSearch.Text != "")
            {
                 searchCustomer = txtCustomerSearch.Text;
                Customer objSql = new Customer(); // create objSql object of the class
                DataSet objDataset = objSql.LoadCustomer(searchCustomer); // call the getCustomers function which returns the Dataset
                dataGridView1.DataSource = objDataset.Tables[0];

            }
            else if (txtCustomerSearch.Text == "")
            {
                Customer objSql = new Customer(); // create objSql object of the class
                DataSet objDataset = objSql.getCustomers(); // call the getCustomers function which returns the Dataset
                dataGridView1.DataSource = objDataset.Tables[0]; // finally Dataset bound to the gridview
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
