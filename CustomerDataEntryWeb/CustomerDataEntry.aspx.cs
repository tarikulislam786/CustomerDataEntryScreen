using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess; // data access layer
using System.Data; // using data set
namespace CustomerDataEntryWeb
{
    public partial class CustomerDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }
        private void loadCustomers() {
            clsSqlServer custObj = new clsSqlServer();
            GridCustomers.DataSource = custObj.getCustomers(); // DATA SOURCE set
            GridCustomers.DataBind(); // bind data to grid
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            // Create a preview Form Object
            
            string sex = "";
            string hobbies = "";
            string email = "";
            bool status = false;
            //Gender selection grab value
            if (male.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            // Hobbies selection grab value
            if (Painting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            //Status selection grab value
            if (Married.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }


            // ADO.net code which will insert data to sql server
            email = txtEmail.Text;
            clsSqlServer insertObj = new clsSqlServer();

            insertObj.InsertCustomer(txtCustomerName.Text, ddlCountries.Text, sex, hobbies, txtEmail.Text, status);
            loadCustomers();
            ClearData();
        }
        private void ClearData()
        {
            txtCustomerName.Text = "";
            txtEmail.Text = "";
            ddlCountries.SelectedIndex = 0;
            male.Checked = false;
            Female.Checked = false;
            Married.Checked = false;
            Unmarried.Checked = false;
            Painting.Checked = false;
            Reading.Checked = false;
        }

        protected void GridCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write some code which will help us to select
            // display the customer details
            // get the selected customer name by the end user from the grid
            string strCustomerName = GridCustomers.Rows[GridCustomers.SelectedIndex].Cells[1].Text;
            ClearData(); // If any data is previously selected then clear it
            // Select the data which is currently clicked
            displayCustomer(strCustomerName);
            
        }
        private void displayCustomer(string custname)
        {
            clsSqlServer custObj = new clsSqlServer();
            DataSet objDataset = custObj.getCustomers(custname);


            // Select the records and display it on the screen
            string strCustomerName = objDataset.Tables[0].Rows[0][0].ToString();
            string strCountryName = objDataset.Tables[0].Rows[0][1].ToString();
            string strGenderName = objDataset.Tables[0].Rows[0][2].ToString();
            string strHobbiesName = objDataset.Tables[0].Rows[0][3].ToString();
            string strEmail = objDataset.Tables[0].Rows[0][4].ToString();
            bool StatusName = false;
            if (objDataset.Tables[0].Rows[0][5] != DBNull.Value) // use bdnull instead of null when we use ado.net, dataset
            {
                StatusName = Convert.ToBoolean(objDataset.Tables[0].Rows[0][5].ToString());
            }
            txtCustomerName.Text = strCustomerName;
            ddlCountries.Text = strCountryName;
            txtEmail.Text = strEmail;
            // Gender
            //string strGenderName = objDataset.Tables[0].Rows[0][2].ToString();
            if (strGenderName == "Male")
            {
                male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
            // Hobbies
            if (strHobbiesName == "Reading")
            {
                Reading.Checked = true;

            }
            else
            {
                Painting.Checked = true;
            }
            // Married
            if (StatusName)
            {
                Married.Checked = true;
            }
            else
            {
                Unmarried.Checked = true;
            }
            // Close the connection
            //objConnection.Close();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Here the update logic will go
            // Lets do some code for update operation
            string email = "";
            string sex = "";
            string hobbies = "";
            bool status = false;
            //Gender selection grab value
            if (male.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            // Hobbies selection grab value
            if (Painting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            //Status selection grab value
            if (Married.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            // ADO.net code which will insert to sql server
            clsSqlServer obj = new clsSqlServer();
            //obj.UpdateCustomer(txtCustomerName.Text, ddlcoun.Text, sex, hobbies, status);
            email = txtEmail.Text;
            obj.UpdateCustomer(txtCustomerName.Text, ddlCountries.Text, sex, hobbies, email, status);

            loadCustomers();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Here the delete logic will go
            clsSqlServer obj = new clsSqlServer();
            obj.DeleteCustomer(txtCustomerName.Text);
            ClearData(); // Clear the selected customer data
            loadCustomers(); // Loading the grid again
        }

    }
}