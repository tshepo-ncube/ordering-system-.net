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
    public partial class AllCustomersControl : UserControl
    {
        public AllCustomersControl()
        {
            InitializeComponent();
        }

        private void AllCustomersControl_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData() {

           /* string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
           // con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            dataGridView1.DataSource = CustomerDB.returnCustomers();

            ;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            if (customer_search_txt.Text.Equals(""))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else {
                string query = String.Format("SELECT * FROM Customers WHERE Name LIKE '{0}%'",customer_search_txt.Text);
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
