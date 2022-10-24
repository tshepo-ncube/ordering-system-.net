using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.DataLayer
{
    class InventoryDB
    {

        public static DataTable allInventory() {
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
           // inventoryDataGridView.DataSource = dt;


        }

        public static DataTable getExpired()
        {
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE ExpiryDate <= '2022-10-17'", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
            //dataGridView1.DataSource = dt;
        }



    }
}
