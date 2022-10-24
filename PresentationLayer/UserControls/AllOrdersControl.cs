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
    public partial class AllOrdersControl : UserControl
    {
        public AllOrdersControl()
        {
            InitializeComponent();
        }

        private void AllOrdersControl_Load(object sender, EventArgs e)
        {
            BindData();
        }


        public void BindData()
        {

          /*  string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            // con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItems", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            order_datagridview.DataSource = AllOrdersDB.allOrderItems(); ;

           /* SqlCommand cmd2 = new SqlCommand("SELECT * FROM Orders", con);

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);*/
            dataGridView1.DataSource = AllOrdersDB.allOrders(); ;


        }

        private void order_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearOrders_Click(object sender, EventArgs e)
        {
            
           /* string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            // con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM OrderItems", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            order_datagridview.DataSource = AllOrdersDB.clearOrderItems(); ;
/*

            SqlCommand cmd2 = new SqlCommand("DELETE FROM Orders", con);

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);*/
            dataGridView1.DataSource = AllOrdersDB.clearOrders() ;


            MessageBox.Show("All orders deleted.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_txt_Click(object sender, EventArgs e)
        {
             
                /*string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
                SqlCommand sqlCommand = new SqlCommand(s);
                SqlConnection con = new SqlConnection(s);
                // con.Open();
                string orderitems_query = String.Format("SELECT * FROM OrderItems", order_search_txt.Text);

                SqlCommand cmd = new SqlCommand(orderitems_query, con);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);*/
                order_datagridview.DataSource = AllOrdersDB.searchOrdersItems(order_search_txt.Text);
/*
                string order_query = String.Format("SELECT * FROM Orders", order_search_txt.Text);
                SqlCommand cmd2 = new SqlCommand(order_query, con);

                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sqlDataAdapter2.Fill(dt2);*/
                dataGridView1.DataSource = AllOrdersDB.searchOrders(order_search_txt.Text) ;
           
             
        }
    }
}
