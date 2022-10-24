using NavigationView.DataLayer;
using NavigationView.Properties;
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
    public partial class CreateCustomer : UserControl
    {
        private string strConn = Settings.Default.Database1ConnectionString;
        //static string  s = Properties.Settings.Database1ConnectionString;
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT INTO CUSTOMERS(Name, Surname, Phone, isBlackListed)
           /* //VALUES('Tshepo', 'Ncube', '52525', 'False');
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Name,Surname,Phone,isBlackListed) VALUES (@pName, @pSurname, @pPhone, @pisBlackListed)", con);
            //SqlCommand sqlCommand = new SqlCommand(s);
            cmd.Parameters.AddWithValue("@pName", name_txt.Text);
            cmd.Parameters.AddWithValue("@pSurname", surname_txt.Text);
            cmd.Parameters.AddWithValue("@pPhone", phone_txt.Text);
            cmd.Parameters.AddWithValue("@pisBlackListed", blacklisted_checkbox.Checked.ToString());
            int res = cmd.ExecuteNonQuery();*/
            CreateCustomerDB.createCustomer(name_txt.Text, surname_txt.Text,phone_txt.Text,blacklisted_checkbox.Checked.ToString());
            //con.Close();
            MessageBox.Show("Customer saved successfully... ");
            name_txt.Clear();
            surname_txt.Clear();
            phone_txt.Clear();
            phone_txt.Clear();
            address_txt.Clear();


            
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
