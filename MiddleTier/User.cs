using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace MiddleTier
{
    public class User
    {
        private string userName = "";
        private string passWord = "";
        // both variables are set by the public property
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }
        public bool isValid() {
            clsSqlServer obj = new clsSqlServer();
            // if we have not found username, and password
            // if this dataset return by the getUser function is not having any rows
            if (obj.getUser(userName, passWord).Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else {
                return true;
            }

        }
    }
    
}
