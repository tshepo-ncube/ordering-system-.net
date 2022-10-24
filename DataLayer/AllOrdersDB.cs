using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.DataLayer
{
    class AllOrdersDB
    {

        public static DataTable allOrders() {
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Orders", con);

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);
            //dataGridView1.DataSource = dt2;
            return dt2;

        }

        public static DataTable allOrderItems() {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            // con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItems", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }


        public static DataTable clearOrders()
        {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);


            SqlCommand cmd2 = new SqlCommand("DELETE FROM Orders", con);

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);
            //dataGridView1.DataSource = dt2;
            return dt2;

            //MessageBox.Show("All orders deleted.");
        }


        public static DataTable clearOrderItems() {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            // con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM OrderItems", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
            //order_datagridview.DataSource = dt;
        }

        public static DataTable searchOrdersItems(string order_search_txt) {
                    if (order_search_txt.Equals(""))
                    {
                        string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                        SqlCommand sqlCommand = new SqlCommand(s);
                        SqlConnection con = new SqlConnection(s);
                        // con.Open();
                        string orderitems_query = String.Format("SELECT * FROM OrderItems", order_search_txt);

                        SqlCommand cmd = new SqlCommand(orderitems_query, con);

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                    else
                    {

                        string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                        SqlCommand sqlCommand = new SqlCommand(s);
                        SqlConnection con = new SqlConnection(s);
                        // con.Open();
                        string orderitems_query = String.Format("SELECT * FROM OrderItems WHERE OrderFkID = '{0}'", order_search_txt);

                        SqlCommand cmd = new SqlCommand(orderitems_query, con);

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sqlDataAdapter.Fill(dt);
                return dt;


                        //MessageBox.Show("All orders deleted.");
                    }
        }


        public static DataTable searchOrders(string order_search_txt)
        {
            if (order_search_txt.Equals(""))
            {
                string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                SqlCommand sqlCommand = new SqlCommand(s);
                SqlConnection con = new SqlConnection(s);
                // con.Open();
                

                string order_query = String.Format("SELECT * FROM Orders", order_search_txt);
                SqlCommand cmd2 = new SqlCommand(order_query, con);

                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sqlDataAdapter2.Fill(dt2);
                return dt2;
            }
            else
            {

                string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                SqlCommand sqlCommand = new SqlCommand(s);
                SqlConnection con = new SqlConnection(s);
                

                string order_query = String.Format("SELECT * FROM Orders WHERE OrderID = '{0}'", order_search_txt);
                SqlCommand cmd2 = new SqlCommand(order_query, con);

                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sqlDataAdapter2.Fill(dt2);
                return dt2;


                //MessageBox.Show("All orders deleted.");
            }
        }

    }
}
