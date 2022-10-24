using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.DataLayer
{
    class AddProductDB
    {

        public static void addProduct(string product_name_txt,string quantity_txt,string unit_price_txt,string expiry_dateview)
        {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory (ProductName,Quantity,Price,ExpiryDate) VALUES (@pProductName, @pQuantity, @pPrice,@pExpiryDate)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pProductName", product_name_txt.ToString());
            cmd.Parameters.AddWithValue("@pQuantity", int.Parse(quantity_txt.ToString()));
            cmd.Parameters.AddWithValue("@pPrice", int.Parse(unit_price_txt.ToString()));

            /*expiry_dateview.CustomFormat = "yyyy-MM-dd";
            Console.WriteLine(expiry_dateview);*/
            cmd.Parameters.AddWithValue("@pExpiryDate", expiry_dateview);

            int res = cmd.ExecuteNonQuery();
             

        }

    }
}
