using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.DataLayer
{
    class CreateOrderDB
    {

        public static DataTable getProducts() {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return dt;

        }

        public static List<Inventory> getInventory()
        {
            List<Inventory> inventories = new List<Inventory>();
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            string queryString =
                "SELECT * from Inventory";
            using (SqlConnection connection = new SqlConnection(
                       s))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int pId = int.Parse(reader[0].ToString());
                        string pName = reader[1].ToString();
                        string price = reader[3].ToString();
                        int quantity = int.Parse(reader[2].ToString());

                        Inventory i = new Inventory(pId, pName, quantity, double.Parse(price));
                        Console.WriteLine(String.Format("{0}, {1} , {2} , {3}",
                           pId, pName, quantity, double.Parse(price)));
                        //Console.WriteLine(double.Parse(price));


                        inventories.Add(i);
                    }
                }
            }

            return inventories;
        }

        public static void createOrder(string customerID,string total,List<OrderItem> orderItems)
        {
            //string stR = customerID.Text.ToString();

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders (CustID, Total) VALUES (@pCustID, @pTotal)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pCustID", customerID);
            cmd.Parameters.AddWithValue("@pTotal", total.ToString());
            //cmd.Parameters.AddWithValue("@pPhone", phone_txt.Text);
            //cmd.Parameters.AddWithValue("@pisBlackListed", blacklisted_checkbox.Checked.ToString());
            int res = cmd.ExecuteNonQuery();
            //MessageBox.Show("Your order has been placed.");
            //con.Close();

            createOrderItems(orderItems);


        }


        public static void createOrderItems(List<OrderItem> orderItems)
        {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            string queryString =
                "SELECT * from Orders";
            string orderId = "";
            using (SqlConnection connection = new SqlConnection(
                       s))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {


                        //Inventory i = new Inventory(pId, pName, quantity, double.Parse(price));
                        //Console.WriteLine(String.Format("{0}, {1} , {2} , {3}",
                        //   pId, pName, quantity, double.Parse(price)));
                        //Console.WriteLine(double.Parse(price));
                        orderId = reader[0].ToString();


                    }






                }
                connection.Close();
            }

            for (int y = 0; y < orderItems.Count; y++)
            {

                //string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                //SqlCommand sqlCommand = new SqlCommand(s);
                SqlConnection con = new SqlConnection(s);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems (ProductName, Quantity, Price, OrderFkID) VALUES (@pProductName, @pQuantity, @pPrice, @pOrderFkID)", con);




                cmd.Parameters.AddWithValue("@pProductName", orderItems[y].getProductName());
                cmd.Parameters.AddWithValue("@pQuantity", orderItems[y].getQuantity());
                cmd.Parameters.AddWithValue("@pPrice", orderItems[y].getPrice());
                cmd.Parameters.AddWithValue("@pOrderFkID", int.Parse(orderId));

                ReserveInventory(y,orderItems);


                int res = cmd.ExecuteNonQuery();

                con.Close();
            }


            //.Show("Your order has been placed.");


            Console.WriteLine(orderId);

        }

        public static Boolean isBlackListed(string n) {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            //string queryString =
            //    "SELECT * from Custoemrs WHERE CustomerID = '{0}'";
            string format = String.Format("Select * from Customers WHERE CustomerID = '{0}'",n);
            string orderId = "";
            using (SqlConnection connection = new SqlConnection(
                       s))
            {
                SqlCommand command = new SqlCommand(
                    format, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {


                        //Inventory i = new Inventory(pId, pName, quantity, double.Parse(price));
                        //Console.WriteLine(String.Format("{0}, {1} , {2} , {3}",
                        //   pId, pName, quantity, double.Parse(price)));
                        //Console.WriteLine(double.Parse(price));
                        //orderId = reader[4].ToString()
                        return bool.Parse(reader[4].ToString());


                    }






                }
                connection.Close();
            }
            return false;
        }

        public static void ReserveInventory(int y,List<OrderItem> orderItems)
        {
            OrderItem item = orderItems[y];

            Console.WriteLine("Reserving items in inventory");
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(s);
            con.Open();
            // SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems (ProductName, Quantity, Price, OrderFkID) VALUES (@pProductName, @pQuantity, @pPrice, @pOrderFkID)", con);




            string query = String.Format("UPDATE Inventory SET Quantity = Quantity - {0} WHERE ProductName='{1}'", item.getQuantity().ToString(), item.getProductName());
            /*cmd.Parameters.AddWithValue("@pProductName", orderItems[y].getProductName());
            cmd.Parameters.AddWithValue("@pQuantity", orderItems[y].getQuantity());
            cmd.Parameters.AddWithValue("@pPrice", orderItems[y].getPrice());
            cmd.Parameters.AddWithValue("@pOrderFkID", int.Parse(orderId));*/
            SqlCommand cmd = new SqlCommand(query, con);


            int res = cmd.ExecuteNonQuery();
            Console.WriteLine(String.Format("{0} reserved...", item.getProductName()));



        }
    }
}
