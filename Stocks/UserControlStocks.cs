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
using System.IO;

namespace Inventory_System_Management_Alliance28.Stocks
{
    public partial class UserControlStocks : UserControl
    {
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public UserControlStocks()
        {
            InitializeComponent();
        }

        private void UserControlStocks_Load(object sender, EventArgs e)
        {

            loadStocks();

            datagridtyle();
            
        }

        //load out of stock products
        public void loadStocks()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP, IMAGE FROM table_products WHERE QUANTITY <= 0 AND STATUS = '" + status + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();


            dataAdapter.SelectCommand = loadCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridStocks.DataSource = dt;



            connection.Close();
        }

        //style datagridview
        public void datagridtyle()
        {
            dataGridStocks.RowTemplate.Height = 50;
            dataGridStocks.Columns[1].Width = 50;
            dataGridStocks.Columns[1].Width = 100;
            dataGridStocks.Columns[2].Width = 200;
            dataGridStocks.Columns[3].Width = 100;
            dataGridStocks.Columns[4].Width = 100;
            dataGridStocks.Columns[5].Width = 100;
            dataGridStocks.Columns[6].Width = 200;
            dataGridStocks.Columns[7].Width = 100;
            dataGridStocks.Columns[8].Width = 100;    


            foreach (DataGridViewColumn column in dataGridStocks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }




            dataGridStocks.EnableHeadersVisualStyles = false;
        }
    }
}
