using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.DataLayer
{
    class CreateCustomerDB
    {

        public static void createCustomer(string name_txt,string surname_txt,string phone_txt,string blackisted_string)
        {
            //INSERT INTO CUSTOMERS(Name, Surname, Phone, isBlackListed)
            //VALUES('Tshepo', 'Ncube', '52525', 'False');
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Name,Surname,Phone,isBlackListed) VALUES (@pName, @pSurname, @pPhone, @pisBlackListed)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pName", name_txt);
            cmd.Parameters.AddWithValue("@pSurname", surname_txt);
            cmd.Parameters.AddWithValue("@pPhone", phone_txt);
            cmd.Parameters.AddWithValue("@pisBlackListed", blackisted_string);
            int res = cmd.ExecuteNonQuery();
            //con.Close();
             
        }

         
    }
}
