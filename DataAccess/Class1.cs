using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //using namespace in in class file
using System.Data; // If we want a dataset in the project then use the namespace
using System.Configuration; // use for ConfigurationManager
namespace DataAccess // name of the class library named DataAccess we just have added new project
{
    public class clsSqlServer
    {
        public DataSet getCountries() {
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            // fire the command object
            // command SQL SQL Server
            SqlCommand objCommand = new SqlCommand("Select * from CountryMaster", objConnection); // Returns rows and columns data
            DataSet objDataset = new DataSet(); //receive these row and column data in c# using DataSet
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); //dataAdapter is the breez between the dataSet and SQL Command.SQL data adapter uses the sql commandObj

            objAdapter.Fill(objDataset);

            // Close the connection
            objConnection.Close();
            return objDataset; //return objDataset
        
        }
        public DataSet getUser(string username, string password) {
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            // fire the command object
            // command SQL SQL Server
            SqlCommand objCommand = new SqlCommand("Select * from Users where UserName = '" + username + "'and Password = '" + password + "'", objConnection); // Returns rows and columns data
            DataSet objDataset = new DataSet(); //receive these row and column data in c# using DataSet
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); //dataAdapter is the breez between the dataSet and SQL Command.SQL data adapter uses the sql commandObj

            objAdapter.Fill(objDataset);

            // Close the connection
            objConnection.Close();
            return objDataset; //return objDataset
        }
        public DataSet getCustomers() {
            
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            // fire the command object
            // command SQL SQL Server
            SqlCommand objCommand = new SqlCommand("Select * from CustomerTable", objConnection); // Returns rows and columns data
            DataSet objDataset = new DataSet(); //receive these row and column data in c# using DataSet
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); //dataAdapter is the breez between the dataSet and SQL Command.SQL data adapter uses the sql commandObj

            objAdapter.Fill(objDataset);

            // Close the connection
            objConnection.Close();
            return objDataset; //return objDataset
        
        }
        public DataSet getCustomers(string custname)
        {

            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            // fire the command object
            // command SQL SQL Server
            SqlCommand objCommand = new SqlCommand("Select * from CustomerTable where CustomerName Like '%" + custname + "%'", objConnection); // Returns rows and columns data
            DataSet objDataset = new DataSet(); //receive these row and column data in c# using DataSet
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand); //dataAdapter is the breez between the dataSet and SQL Command.SQL data adapter uses the sql commandObj

            objAdapter.Fill(objDataset);

            // Close the connection
            objConnection.Close();
            return objDataset; //return objDataset

        }
        public bool InsertCustomer(string strCustname, string strCountry, string strGender, string strHobby, string Email, bool status)
        {
            // Open a connection
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            try
            {

                //Command Insert Fire
                string strInsertCommand = "insert into CustomerTable values('"
                + strCustname + "','"
                + strCountry + "','"
                + strGender + "','"
                + strHobby + "','"
                + Email + "'," + 
                Convert.ToInt16(status) +")";

                SqlCommand objCommand = new SqlCommand(strInsertCommand, objConnection); //Run the Sql Command
                objCommand.ExecuteNonQuery(); //Execute the SQL Command
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally {
                // Close the connection
                objConnection.Close();
            }

        }
        public bool UpdateCustomer(string strCustname, string strCountry, string strGender, string strHobby, string Email, bool status)
        { 
        // Open a connection
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            //Command Update Fire
            string strUpdateCommand = "update CustomerTable set CustomerName ='"
            + strCustname + "',CountryId_FK='"
            + strCountry + "',Gender='"
            + strGender + "',Hobbies='"
            + strHobby + "',Email='"
            +Email+"',Married='"
            + Convert.ToInt16(status) +

            "' where CustomerName = '" + strCustname + "'";

            SqlCommand objCommand = new SqlCommand(strUpdateCommand, objConnection); //Run the Sql Command
            objCommand.ExecuteNonQuery(); //Execute the SQL Command
            // Close the connection
            objConnection.Close();
            return true;
        }
        public bool DeleteCustomer(string custname) {
            // Open a connection
            //string Connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tarik\Documents\UserDb.mdf;Integrated Security=True;Connect Timeout=30";
            string Connectionstring = ConfigurationManager.ConnectionStrings["Dbconn"].ToString(); //use connection string from app config file
            SqlConnection objConnection = new SqlConnection(Connectionstring);// create sqlconnection obj & view connectionstring
            objConnection.Open();
            //Command DELETE Fire
            string strDeleteCommand = "Delete from CustomerTable where CustomerName = '" + custname + "'";

            SqlCommand objCommand = new SqlCommand(strDeleteCommand, objConnection); //Run the Sql Command
            objCommand.ExecuteNonQuery(); //Execute the SQL Command
            // Close the connection
            objConnection.Close();
            return true;
        }

      /*  public void InsertCustomer(string p1, string p2, string sex, string hobbies, string email, bool status)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string p1, string p2, string sex, string hobbies, string email, bool status)
        {
            throw new NotImplementedException();
        }*/
    }
}
