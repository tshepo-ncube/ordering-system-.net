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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {

           /* string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            inventoryDataGridView.DataSource = InventoryDB.allInventory(); ;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void pastDate() {

            DateTime d = new DateTime();
            

            /*string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            SqlCommand sqlCommand = new SqlCommand(s);
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE ExpiryDate <= '2022-10-17'", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);*/
            dataGridView1.DataSource = InventoryDB.getExpired(); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pastDate();
        }
    }
}
