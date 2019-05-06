using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleTier;
namespace CustomerDataEntryScreen
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            // We need to call the user class to check if the
            // user is valid or not
            User obj = new User();
            obj.UserName = txtUsername.Text;
            obj.Password = txtPassword.Text;

            if (obj.isValid())
            {
                // valid user
                /*MDIParent1 objMdi = new MDIParent1();
                objMdi.Show();*/
                Close(); // Once the credential match close login form
            }
            else { 
            // invalid user
                MessageBox.Show("Invalid Credentials");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        /*public void SetValues(string customerName, string countryName, string genderName, string hobbyName, string statusName) {
            lblCustomerData.Text = customerName;
            lblCountryData.Text = countryName;
            lblSexData.Text = genderName;
            lblHobbiesData.Text = hobbyName;
            lblStatusData.Text = statusName;
        }*/
    }
}
