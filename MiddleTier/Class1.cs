using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions; // add this for using regex(pattern matching technology) validation
using DataAccess;
namespace MiddleTier
{
    // THis middle Tier or Customer class for business validation
    public class Customer 
    {
        // write all 5 properties here
        private string _CustomerName = "";
        private string _CountryName = "";
        private string _Gender = "";
        private string _Hobbies = "";
        private bool _IsMarried = false;
        private string _Email = "";
        // public get and set of each field (Encapsulation)
        public string Email {
            get { return _Email; }
            set {
                
                if (value.Length == 0) {
                    throw new Exception("Email required");
                }
                
                // alphanumeric@alphanumeric.com
                // carret specify start of regex & $ specify end of regex
                //{1,20} denotes the min 1 and max 20 letter
                Regex o = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
                if (!o.IsMatch(value)) {
                    throw new Exception("Email address is not in a proper format");
                }
                _Email = value;
            }
        }
        public string CustomerName {
            get { return _CustomerName; }
            set {
                if (value.Length == 0) {
                    throw new Exception("Customer Name is Required");
                }
                if (value.Length > 15) {
                    throw new Exception("Name can not be greater than 20 characters");
                }
                _CustomerName = value; 
            }
        }
       
        public string CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }
        
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        
        public string Hobbies
        {
            get { return _Hobbies; }
            set { _Hobbies = value; }
        }
        
        public bool IsMarried
        {
            get { return _IsMarried; }
            set { _IsMarried = value; }
        }

        // Then create public set and get properties
        public void save() { 
            // we will make a call to Data Access Layer to Insert
            //these value to SQL Server
            clsSqlServer obj = new clsSqlServer();
            obj.InsertCustomer(_CustomerName, _CountryName, _Gender, _Hobbies, _Email, _IsMarried);
        }
        public void DeleteCustomer(string CustomerName)
        {
            clsSqlServer obj = new clsSqlServer();
            obj.DeleteCustomer(CustomerName);

        }
        public void UpdateCustomer(string CustomerName, string CountryName, string Gender, string Hobbies,string Email, bool IsMarried)
        {
            clsSqlServer obj = new clsSqlServer();
            obj.UpdateCustomer(CustomerName, CountryName, Gender, Hobbies, Email, IsMarried);
        }
        public DataSet LoadCustomer() {
            clsSqlServer obj = new clsSqlServer();
            return obj.getCustomers();
        }
        public DataSet LoadCustomer(string CustomerName)
        {
            clsSqlServer obj = new clsSqlServer();
            return obj.getCustomers(CustomerName);
        }
        public DataSet getCustomers() {
            clsSqlServer obj = new clsSqlServer();
            return obj.getCustomers();
        }
        
    }
}
