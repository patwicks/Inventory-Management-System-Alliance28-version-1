using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Inventory_System_Management_Alliance28
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            
        }


        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            countProducts();
            timerProduct.Start();

            //current time and data
            //lbCurrentTime.Text = DateTime.Now.ToLongTimeString();
            lbCurrenDate.Text = DateTime.Now.ToLongDateString();
        }

        //count products

        public void countProducts()
        {
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT ITEMCODE FROM table_products";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            lbProduct.Text = dt.Rows.Count.ToString();
        }

        private void timerProduct_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(lbProduct.Text);

            if(lbProduct.Text == "000000")
            {
                return;
            }
            else if (val < Int32.Parse(lbProduct.Text))
            {
                val += 1;
                lbProduct.Text = val.ToString();
            }
            else
            {
                timerProduct.Stop();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text  = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
