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
    public partial class CreateInventory : UserControl
    {
        public CreateInventory()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addProduct();
            //Console.WriteLine(expiry_dateview.Text);
            //2023 - 01 - 22'
           // expiry_dateview.CustomFormat = "yyyy-MM-dd";
            //Console.WriteLine(expiry_dateview.Text);
            //expiry_dateview.CustomFormat
        }

        private void CreateInventory_Load(object sender, EventArgs e)
        {

        }

        public void addProduct() {

            /*string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory (ProductName,Quantity,Price,ExpiryDate) VALUES (@pProductName, @pQuantity, @pPrice,@pExpiryDate)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pProductName", product_name_txt.Text.ToString());
            cmd.Parameters.AddWithValue("@pQuantity", int.Parse(quantity_txt.Text.ToString()));
            cmd.Parameters.AddWithValue("@pPrice", int.Parse(unit_price_txt.Text.ToString()));
            
            
            cmd.Parameters.AddWithValue("@pExpiryDate", expiry_dateview.Text);

            int res = cmd.ExecuteNonQuery();
            //con.Close();*/
            expiry_dateview.CustomFormat = "yyyy-MM-dd";
            Console.WriteLine(expiry_dateview.Text);
            //string product_name_txt,string quantity_txt,string unit_price_txt,string expiry_dateview
            AddProductDB.addProduct(product_name_txt.Text.ToString(), quantity_txt.Text, unit_price_txt.Text.ToString(), expiry_dateview.Text);


            MessageBox.Show("product saved successfully... " 
            );
            product_name_txt.Clear();
            quantity_txt.Clear();
            unit_price_txt.Clear();
            
        }
    }
}
