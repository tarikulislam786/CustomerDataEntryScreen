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
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void frmCustomerDataEntry_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadCountries();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            // Create a preview Form Object
            //frmPreviewCustomer obj2 = new frmPreviewCustomer();
            // Create the object of the class
            try
            {
                Customer objCustomer = new Customer();
                objCustomer.CustomerName = txtCustomerName.Text;
                // objCustomer.CmbCountryId = Convert.ToInt16(cmbCountryName.SelectedValue);
                objCustomer.CountryName = cmbCountryName.Text;


                string sex = "";
                string hobbies = "";
                bool status = false;
                //Gender selection grab value
                if (radioMale.Checked)
                {
                    sex = "Male";
                }
                else
                {
                    sex = "Female";
                }
                objCustomer.Gender = sex;
                // Hobbies selection grab value
                if (checkPainting.Checked)
                {
                    hobbies = "Painting";
                }
                else
                {
                    hobbies = "Reading";
                }
                objCustomer.Hobbies = hobbies;
                objCustomer.Email = txtEmail.Text;
                //Status selection grab value
                objCustomer.IsMarried = radioMarried.Checked;

                objCustomer.save();
                /*obj2.SetValues(txtCustomerName.Text, 
                              cmbCountryName.Text.ToString(), 
                              sex, hobbies, status);
                obj2.ShowDialog();*/

                // ADO.net code which will insert data to sql server

                LoadCustomer();
                ClearData(); // clear form
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void LoadCountries() {
            Country objCountry = new Country();
            cmbCountryName.DisplayMember = "CountryName";
            cmbCountryName.ValueMember = "CountryId";
            cmbCountryName.DataSource = objCountry.getCountries().Tables[0];
        }
        private void LoadCustomer() {

            Customer objCustomer = new Customer();
            //DataSet objDataset = objCustomer.getCustomers(); //receive these row and column data in c# using DataSet

            //// Bind the data to the UI
            dtgCustomer.DataSource = objCustomer.LoadCustomer().Tables[0];// Dataset bound to datagrid

        }

        private void ClearData() {

            txtCustomerName.Text = "";
            txtEmail.Text = "";
            cmbCountryName.SelectedIndex = 0;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;
            checkPainting.Checked = false;
            checkReading.Checked = false;

        }
        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayCustomer(string custname)
        {
            Customer Obj = new Customer();
            DataSet objDataset = Obj.LoadCustomer(custname);
            

            //// Select the records and display it on the screen
            string strCustomerName = objDataset.Tables[0].Rows[0][0].ToString();
            string strCountryName = objDataset.Tables[0].Rows[0][1].ToString();
            string strGenderName = objDataset.Tables[0].Rows[0][2].ToString();
            string strHobbiesName = objDataset.Tables[0].Rows[0][3].ToString();
            string strEmail = objDataset.Tables[0].Rows[0][4].ToString();
            bool StatusName = false;

            if (objDataset.Tables[0].Rows[0][2] != DBNull.Value) // use bdnull instead of null when we use ado.net, dataset
            {
                strGenderName = objDataset.Tables[0].Rows[0][2].ToString().Trim();
            }
            if (objDataset.Tables[0].Rows[0][3] != DBNull.Value) // use bdnull instead of null when we use ado.net, dataset
            {
                strHobbiesName = objDataset.Tables[0].Rows[0][3].ToString().Trim();
            }
            if (objDataset.Tables[0].Rows[0][5] != DBNull.Value) // use bdnull instead of null when we use ado.net, dataset
            {
                StatusName = Convert.ToBoolean(objDataset.Tables[0].Rows[0][5].ToString());
            }
            txtCustomerName.Text = strCustomerName;
            cmbCountryName.Text = strCountryName;
            txtEmail.Text = strEmail;
            // Gender

            if (strGenderName == "Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
            // Hobbies
            if (strHobbiesName == "Reading")
            {
                checkReading.Checked = true;
                checkPainting.Checked = false;

            }
            else
            {
                checkPainting.Checked = true;
                checkReading.Checked = false;
            }
            // Married
            if (StatusName)
            {
                radioMarried.Checked = true;
            }
            else
            {
                radioUnmarried.Checked = true;
            }
            // Close the connection
            //objConnection.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // the selected customer code will be deleted from here
            Customer DeleteObj = new Customer();
            DeleteObj.DeleteCustomer(txtCustomerName.Text);
            LoadCustomer();
            ClearData(); // clear form
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // In this section we will get the customercode which 
            // is selected
            string strSelectedCustomer = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            // e.rowindex get the selected row
            // Zero th cells gets the customercode
            
            displayCustomer(strSelectedCustomer);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lets do some code for update operation
            //Customer objCustomer = new Customer();
            int CmbCountryId = 0;
            string sex = "";
            string hobbies = "";
            bool status = false;
            //Gender selection grab value
            if (radioMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            // Hobbies selection grab value
            if (checkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            //Status selection grab value
            if (radioMarried.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            // ADO.net code which will insert to sql server
            Customer updateObj = new Customer();
            CmbCountryId = Convert.ToInt16(cmbCountryName.SelectedValue);
            updateObj.UpdateCustomer(txtCustomerName.Text, cmbCountryName.Text, sex, hobbies, txtEmail.Text, status);
            
            LoadCustomer();
            ClearData(); // clear form
        }

        private void cmbCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
