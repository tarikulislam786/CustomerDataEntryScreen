using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiddleTier; //using MiddleTier
using System.Web.Security; // using web form authentication
namespace CustomerDataEntryWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            objUser.UserName = txtUsername.Text;
            objUser.Password = txtPassword.Text;

            if (objUser.isValid())
            {
                FormsAuthentication.RedirectFromLoginPage(objUser.UserName,true);
            }
            else { 
                //return false;
            }
        }
    }
}