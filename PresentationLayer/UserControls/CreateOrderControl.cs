using NavigationView.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView.UserControls
{
    public partial class CreateOrderControl : UserControl
    {

        //string customer_id = customerID.Text.ToString();

        List<OrderItem> orderItems = new List<OrderItem>();
        List<Inventory> inventories;//= new List<Inventory>();
        double total = 0;

        public CreateOrderControl()
        {
            InitializeComponent();
        }



        private void add_order_item_btn_Click(object sender, EventArgs e)
        {

            if (productsCombo.Text.Length == 0 || quantity_txt.Text.Length == 0)
            {

                MessageBox.Show("Please enter valid arguments");


            }
            else {
                OrderItem orderItem = new OrderItem();
                orderItem.setProductName(productsCombo.Text.ToString()) ;
                orderItem.setQuantity(int.Parse(quantity_txt.Text));

                for (int x=0;x< inventories.Count;x++) {
                    
                    if (inventories[x].getProductName().Equals(productsCombo.Text)) {
                        Console.WriteLine("found");
                        total += inventories[x].getPrice() * int.Parse(quantity_txt.Text);
                        orderItem.setPrice(inventories[x].getPrice() * int.Parse(quantity_txt.Text));

                    }
                    total_price_txt.Text = String.Format("R{0}.00", total.ToString());
                }


                orderItems.Add(orderItem);
               // MessageBox.Show("");

               // listView1.Items.Add(orderItem.getProductName());


                ListViewItem listViewItem = new ListViewItem((orderItems.Count-1).ToString());
                listViewItem.SubItems.Add(orderItem.getProductName());
                listViewItem.SubItems.Add(quantity_txt.Text);
                listViewItem.SubItems.Add(orderItem.getPrice().ToString());
                listView1.Items.Add(listViewItem);

                //productsCombo.;
                quantity_txt.Clear();

            }
        }


        public void comboWork() {

            /*string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            

            //List<OrderItem> orderItems = new List<OrderItem>();
            /*OrderItem orderItem = new OrderItem();
            orderItem.setProductName("w23232");
            orderItem.setQuantity(2332);
            orderItem.setPrice(100);
            orderItems.Add(orderItem);*/

            productsCombo.DataSource = CreateOrderDB.getProducts(); ;
            //productsCombo.ValueMember = "ProductName";
            //productsCombo.DisplayMember = "ProductName";




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateOrderControl_Load(object sender, EventArgs e)
        {
            comboWork(); 
             //comboWorkCustomer();
             inventories =  CreateOrderDB.getInventory();
        }

        private void productsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct_txt.Text = productsCombo.Text;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* public void comboWorkCustomer()
        {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);


            List<OrderItem> orderItems = new List<OrderItem>();
            OrderItem orderItem = new OrderItem();
            orderItem.setProductName("w23232");
            orderItem.setQuantity(2332);
            orderItem.setPrice(100);
            orderItems.Add(orderItem);

            customersCombo.DataSource = dt;
            //productsCombo.ValueMember = "ProductName";
            //productsCombo.DisplayMember = "ProductName";




        }*/

        private void completeOrderBtn_Click(object sender, EventArgs e)
        {
            //createOrderItems();
            completeOrder();
            //Console.WriteLine("hey there");
            //Console.WriteLine(total);
            //ReadOrderData();
        }

        private void getInventory()
        {
            /*string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

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
                        
                        Inventory i = new Inventory(pId,pName,quantity,double.Parse(price));
                        Console.WriteLine(String.Format("{0}, {1} , {2} , {3}",
                           pId , pName, quantity, double.Parse(price)));
                        //Console.WriteLine(double.Parse(price));

                        
                        inventories.Add(i);
                    }
                }
            }*/
        }

        public void completeOrder() {

            

            if (orderItems.Count < 3) {

                MessageBox.Show("Please enter at least 3 products.");
                return;
            }

            if (customerID.Text.Equals(""))
            {
                MessageBox.Show("Please enter a customer ID");
                return;
            }
            else {
                if (checkIfCustomerIsBlackListed())
                {
                    MessageBox.Show("Customer is blackisted");
                }
                else
                {
                    //createOrder();
                    CreateOrderDB.createOrder(customerID.Text, total.ToString(), orderItems);
                   
                    customerID.Text = "";
                    quantity_txt.Text = "";
                    total_price_txt.Text =  "R00.00";
                    listView1.Items.Clear();
                    MessageBox.Show("Your order has been placed.");
                }
            }
        
        }

        public Boolean checkIfCustomerIsBlackListed() {
            return CreateOrderDB.isBlackListed(customerID.Text);
        }

        /*public void createOrder() {
            string stR = customerID.Text.ToString();

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders (CustID, Total) VALUES (@pCustID, @pTotal)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pCustID", customerID.Text);
            cmd.Parameters.AddWithValue("@pTotal", total.ToString());
            //cmd.Parameters.AddWithValue("@pPhone", phone_txt.Text);
            //cmd.Parameters.AddWithValue("@pisBlackListed", blacklisted_checkbox.Checked.ToString());
            int res = cmd.ExecuteNonQuery();
            //MessageBox.Show("Your order has been placed.");
            //con.Close();

            createOrderItems();


        }*/

        /*public void createOrderItems() {

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

                ReserveInventory(y);
                

                int res = cmd.ExecuteNonQuery();

                con.Close();
            }


            MessageBox.Show("Your order has been placed.");


            Console.WriteLine(orderId);

        }

        public void ReserveInventory(int y) {
            OrderItem item = orderItems[y];

            Console.WriteLine("Reserving items in inventory");
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(s);
            con.Open(); 
           // SqlCommand cmd = new SqlCommand("INSERT INTO OrderItems (ProductName, Quantity, Price, OrderFkID) VALUES (@pProductName, @pQuantity, @pPrice, @pOrderFkID)", con);
            
           


            string query = String.Format("UPDATE Inventory SET Quantity = Quantity - {0} WHERE ProductName='{1}'",item.getQuantity().ToString(),item.getProductName());
            *//*cmd.Parameters.AddWithValue("@pProductName", orderItems[y].getProductName());
            cmd.Parameters.AddWithValue("@pQuantity", orderItems[y].getQuantity());
            cmd.Parameters.AddWithValue("@pPrice", orderItems[y].getPrice());
            cmd.Parameters.AddWithValue("@pOrderFkID", int.Parse(orderId));*//*
            SqlCommand cmd = new SqlCommand(query, con);
            

            int res = cmd.ExecuteNonQuery();
            Console.WriteLine(String.Format("{0} reserved...",item.getProductName()));



        }*/

        /*public void productsGet() {

            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            // con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory ", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            //dataGridView1.DataSource = dt;

        }*/

        private void removeOrderItem_btn_Click(object sender, EventArgs e)
        {
            
            listView1.Items.RemoveAt(int.Parse(orderItem_txt.Text));
        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}